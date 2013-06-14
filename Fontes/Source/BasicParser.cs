using System;
using System.Collections.Generic;

namespace Heurys.Patterns.HPattern
{
	/// <summary>
	/// (Very) basic parser to process GeneXus code.
	/// Blocks are identified by finding the start and ending tokens specified
	/// in the public methods. All these tokens <b>must</b> be in the same line
	/// for the parsing to work.
	/// </summary>
	public class BasicParser
	{
		private string[] m_Text = new string[0];
		private bool m_ErrorOnUnbalancedBlocks = true;

		/// <summary>
		/// Initializes a new instance of the basic parser for the specified string.
		/// </summary>
		/// <param name="text">The text to be parsed and modified.</param>
		public BasicParser(string text)
		{
			if (text == null)
				text = String.Empty;

			m_Text = DivideLines(text);
		}

		/// <summary>
		/// Gets the current form of the text that is being processed.
		/// </summary>
		public string Text
		{
			get { return String.Join(Environment.NewLine, m_Text); }
		}

		/// <summary>
		/// Gets and sets whether an exception (BasicParserException) must be raised 
		/// if a block start is found that does not have a corresponding block ending. 
		/// Default value is <b>true</b>.
		/// </summary>
		public bool ErrorOnUnbalancedBlocks
		{
			get { return m_ErrorOnUnbalancedBlocks; }
			set { m_ErrorOnUnbalancedBlocks = value; }
		}

		/// <summary>
		/// Gets the block of text delimited by the specified starting and ending tokens.
		/// The lines that contain the tokens are included.
		/// </summary>
		/// <param name="startTokens">Token sequence that marks the the start of the block.</param>
		/// <param name="endTokens">Token sequence that marks the end of the block.</param>
		/// <returns>The text block, if found, otherwise <b>null</b>.</returns>
		public string GetBlock(string[] startTokens, string[] endTokens)
		{
			return GetBlock(startTokens, endTokens, 0, false);
		}
		
		/// <summary>
		/// Gets the block of text delimited by the specified starting and ending tokens.
		/// The lines that contain the tokens are included.
		/// </summary>
		/// <param name="startTokens">Token sequence that marks the the start of the block.</param>
		/// <param name="endTokens">Token sequence that marks the end of the block.</param>
		/// <param name="startAtLine">Line (zero-based) from which the search will be performed.</param>
		/// <param name="checkNotCommented">Determines whether commented lines that contain the tokens will be considered or not.</param>
		/// <returns>The text block, if found, otherwise <b>null</b>.</returns>
		public string GetBlock(string[] startTokens, string[] endTokens, int startAtLine, bool checkNotCommented)
		{
			IList<string> oneBlock = InternalGetBlocks(1, startTokens, endTokens, startAtLine, checkNotCommented);
			if (oneBlock.Count > 0)
				return (string)oneBlock[0];
			else
				return null;
		}

		/// <summary>
		/// Gets all the blocks of text contained in the file that are delimited by the
		/// specified starting and ending token sequences.
		/// </summary>
		/// <param name="startTokens">Token sequence that marks the the start of a block.</param>
		/// <param name="endTokens">Token sequence that marks the end of a block.</param>
		/// <returns>An array containing the text blocks found.</returns>
		public string[] GetBlocks(string[] startTokens, string[] endTokens)
		{
			return GetBlocks(startTokens, endTokens, 0, false);
		}

		/// <summary>
		/// Gets all the blocks of text contained in the file that are delimited by the
		/// specified starting and ending token sequences.
		/// </summary>
		/// <param name="startTokens">Token sequence that marks the the start of a block.</param>
		/// <param name="endTokens">Token sequence that marks the end of a block.</param>
		/// <param name="startAtLine">Line (zero-based) from which the search will be performed.</param>
		/// <param name="checkNotCommented">Determines whether commented lines that contain the tokens will be considered or not.</param>
		/// <returns>An array containing the text blocks found.</returns>
		public string[] GetBlocks(string[] startTokens, string[] endTokens, int startAtLine, bool checkNotCommented)
		{
			List<string> blocks = InternalGetBlocks(Int32.MaxValue, startTokens, endTokens, startAtLine, checkNotCommented);
			return blocks.ToArray();
		}

		private List<String> InternalGetBlocks(int maxBlockCount, string[] startTokens, string[] endTokens, int startAtLine, bool checkNotCommented)
		{
			int blockIndex = 0;
			int firstLine = startAtLine;
			List<string> blocks = new List<string>();

			while (blockIndex < maxBlockCount)
			{
				LineRange range = InternalFindBlock(m_Text, startTokens, endTokens, firstLine, checkNotCommented);
				if (range != null)
				{
					// Get this block.
					string[] blockLines = new string[range.LineCount];
					for (int i = range.First; i <= range.Last; i++)
						blockLines[i - range.First] = m_Text[i];

					blocks.Add(String.Join(Environment.NewLine, blockLines));
					firstLine = range.Last + 1;
					blockIndex++;
				}
				else
					break;
			}

			return blocks;
		}

		/// <summary>
		/// Comments any block of text delimited by the specified starting and ending tokens.
		/// The lines that contain the tokens are included.
		/// </summary>
		/// <param name="startTokens">Token sequence that marks the the start of a block.</param>
		/// <param name="endTokens">Token sequence that marks the end of a block.</param>
		public void CommentBlocks(string[] startTokens, string[] endTokens)
		{
			bool keepCommenting = true;
			while (keepCommenting)
				keepCommenting = CommentBlock(startTokens, endTokens);
		}

		/// <summary>
		/// Comments the block of text delimited by the specified starting and ending tokens.
		/// The lines that contain the tokens are included.
		/// </summary>
		/// <param name="startTokens">Token sequence that marks the the start of the block.</param>
		/// <param name="endTokens">Token sequence that marks the end of the block.</param>
		/// <returns><b>True</b> if any blocks were commented, otherwise <b>false</b>.</returns>
		public bool CommentBlock(string[] startTokens, string[] endTokens)
		{
			LineRange range = InternalFindBlock(m_Text, startTokens, endTokens, 0, true);
			if (range != null)
			{
				for (int i = range.First; i <= range.Last; i++)
					m_Text[i] = CommentLine(m_Text[i]);
				return true;
			}
			else
				return false;
		}

		/// <summary>
		/// Deletes all the blocks of text delimited by the specified starting and ending tokens.
		/// The lines that contain the tokens are included.
		/// </summary>
		/// <param name="startTokens">Token sequence that marks the the start of the block.</param>
		/// <param name="endTokens">Token sequence that marks the end of the block.</param>
		public void DeleteBlocks(string[] startTokens, string[] endTokens)
		{
			bool keepDeleting = true;
			while (keepDeleting)
				keepDeleting = DeleteBlock(startTokens, endTokens);
		}

		/// <summary>
		/// Deletes the block of text delimited by the specified starting and ending tokens.
		/// The lines that contain the tokens are included.
		/// </summary>
		/// <param name="startTokens">Token sequence that marks the the start of the block.</param>
		/// <param name="endTokens">Token sequence that marks the end of the block.</param>
		/// <returns><b>True</b> if any blocks were deleted, otherwise <b>false</b>.</returns>
		public bool DeleteBlock(string[] startTokens, string[] endTokens)
		{
			return DeleteBlock(startTokens, endTokens, 0, false);
		}

		/// <summary>
		/// Deletes the block of text delimited by the specified starting and ending tokens.
		/// The lines that contain the tokens are included.
		/// </summary>
		/// <param name="startTokens">Token sequence that marks the the start of the block.</param>
		/// <param name="endTokens">Token sequence that marks the end of the block.</param>
		/// <param name="startAtLine">Line (zero-based) from which the search will be performed.</param>
		/// <param name="checkNotCommented">Determines whether commented lines that contain the tokens will be considered or not.</param>
		/// <returns><b>True</b> if any blocks were deleted, otherwise <b>false</b>.</returns>
		public bool DeleteBlock(string[] startTokens, string[] endTokens, int startAtLine, bool checkNotCommented)
		{
			LineRange range = InternalFindBlock(m_Text, startTokens, endTokens, startAtLine, checkNotCommented);
			if (range != null)
			{
				string[] newText = new string[m_Text.Length - range.LineCount];
				for (int i = 0; i < m_Text.Length; i++)
				{
					if (i < range.First)
						newText[i] = m_Text[i];
					else if (i > range.Last)
						newText[i - range.LineCount] = m_Text[i];
				}

				m_Text = newText;
				return true;
			}
			else
				return false;
		}

		/// <summary>
		/// Inserts the specified block before the specified line.
		/// </summary>
		/// <param name="line">Line where the block should be inserted</param>
		/// <param name="block">Block of text to be inserted.</param>
		public void InsertBefore(int line, string block)
		{
			string[] blockLines = DivideLines(block);
			int newTextLength = m_Text.Length + blockLines.Length;
			string[] newText = new string[newTextLength];

			for (int i = 0; i < newTextLength; i++)
			{
				if (i < line)
					newText[i] = m_Text[i];
				else if (i < line + blockLines.Length)
					newText[i] = blockLines[i - line];
				else
					newText[i] = m_Text[i - blockLines.Length];
			}

			m_Text = newText;
		}

		/// <summary>
		/// Inserts the specified block before the first occurrence of <b>tokens</b>.
		/// </summary>
		/// <param name="tokens">Token sequence.</param>
		/// <param name="block">Block of text to be inserted.</param>
		/// <returns><b>true</b>if an insertion was performed, otherwise <b>false</b>.</returns>
		public bool InsertBefore(string[] tokens, string block)
		{
			LineRange range = InternalFindBlock(m_Text, tokens, new string[] {""});
			if (range != null)
			{
				InsertBefore(range.First, block);
				return true;
			}

			// No insertion performed.
			return false;
		}

		/// <summary>
		/// Replaces the block delimited by the specified token sequences (including the tokens
		/// themselves) with another block.
		/// </summary>
		/// <param name="startTokens">Token sequence that marks the the start of the block to replace.</param>
		/// <param name="endTokens">Token sequence that marks the end of the block to replace.</param>
		/// <param name="newBlock">Text used to replace the current block.</param>
		/// <returns><b>true</b> if the original text was found and replaced, otherwise <b>false</b>.</returns>
		public bool ReplaceBlock(string[] startTokens, string[] endTokens, string newBlock)
		{
			LineRange range = InternalFindBlock(m_Text, startTokens, endTokens, 0, true);
			if (range != null)
			{
				string[] replaceText = DivideLines(newBlock);
				int newTextLength = m_Text.Length - range.LineCount + replaceText.Length;
				string[] newText = new string[newTextLength];

				for (int i= 0; i < newTextLength; i++)
				{
					if (i < range.First)
						newText[i] = m_Text[i];
					else if (i < replaceText.Length + range.First)
						newText[i] = replaceText[i - range.First];
					else 
						newText[i] = m_Text[i - replaceText.Length + range.LineCount];
				}

				m_Text = newText;
				return true;
			}

			// No replacement performed.
			return false;
		}

		#region Block parsing methods

		private LineRange InternalFindBlock(string[] lines, string[] startTokens, string[] endTokens)
		{
			return InternalFindBlock(lines, startTokens, endTokens, 0, false);
		}

		private LineRange InternalFindBlock(string[] lines, string[] startTokens, string[] endTokens, int startAtLine, bool checkNotCommented)
		{
			int iLine = startAtLine;
			while (iLine < lines.Length)
			{
				string line = lines[iLine];
				if (LineContainsTokens(line, startTokens, checkNotCommented))
				{
					// Found start of Block, is ending present?
					int iBlockBegin = iLine;
					int iBlockEnd = FindBlockEndLine(lines, iBlockBegin, endTokens, checkNotCommented);
					if (iBlockEnd != -1)
						return new LineRange(iBlockBegin, iBlockEnd);
					else
						return null;
				}

				iLine++;
			}

			return null;
		}

		internal bool LineContainsTokens(string line, string[] tokens, bool checkNotCommented)
		{
			if (checkNotCommented && IsCommentedLine(line))
				return false;

			bool mustBeAtStart = false;
			line = line.ToLower().Trim();
			foreach (string collectionToken in tokens)
			{
				// See that every token is contained in this line in order, and that only spaces separate them.
				string token = collectionToken.ToLower().Trim();
                if (token == "event" || token == "sub")
                {
                    token = token + " ";
                    mustBeAtStart = true;
                }
                bool cansearch = (token != "event" || line.IndexOf("jsevent") < 0 ? true : false);
                if (cansearch && ((!mustBeAtStart && line.IndexOf(token) != -1) || (line.IndexOf(token) == 0)))
				{
					line = line.Substring(line.IndexOf(token) + token.Length).Trim();
					mustBeAtStart = true;
				}
				else
					return false;
			}

			// Every token found, so matches ok.
			return true;
		}

		private int FindBlockEndLine(string[] lines, int startLine, string[] blockEndTokens, bool checkNotCommented)
		{
			int iEndLine = -1;
			for (int i = startLine; i < lines.Length; i++)
			{
				if (LineContainsTokens(lines[i], blockEndTokens, checkNotCommented))
				{
					iEndLine = i;
					break;
				}
			}

			// Found end of block.
			if (iEndLine == -1 && ErrorOnUnbalancedBlocks)
				throw new BasicParserException(String.Format("Block end marker ({0}) not found.", String.Join(" ", blockEndTokens)));

			return iEndLine;
		}

		internal string[] DivideLines(string text)
		{
			string[] lines = text.Split('\n');
			for (int i = 0; i < lines.Length; i++)
				lines[i] = lines[i].TrimEnd('\n', '\r');
			return lines;
		}

		private string CommentLine(string line)
		{
			if (!IsCommentedLine(line))
				return "// " + line;
			else
				return line;
		}

		private bool IsCommentedLine(string line)
		{
			return (line.TrimStart().StartsWith("//"));
		}

		#endregion

		#region LineRange class

		/// <summary>
		/// Class used to store a range of lines.
		/// </summary>
		private class LineRange
		{
			public readonly int First;
			public readonly int Last;

			public LineRange(int first, int last)
			{
				First = first;
				Last = last;
			}

			public int LineCount
			{
				get { return (Last - First) + 1; }
			}
		}

		#endregion

        public string[] MText
        {
            get { return m_Text; }
            set { m_Text = value; }
        }
	}

	#region Exception Class

	/// <summary>
	/// Exception class for errors that occur during parsing with the <b>BasicParser</b> class.
	/// </summary>
	public class BasicParserException : ApplicationException
	{
		/// <summary>
		/// Initializes a new instance of the BasicParserException class.
		/// </summary>
		public BasicParserException() : base() {}

		/// <summary>
		/// Initializes a new instance of the BasicParserException class with a specified error message.
		/// </summary>
		/// <param name="message">The message that describes the error.</param>
		public BasicParserException(string message) : base(message) {}

		/// <summary>
		/// Initializes a new instance of the BasicParserException class with a specified error message and a reference to the inner exception that is the cause of this exception.
		/// </summary>
		/// <param name="message">The message that describes the error.</param>
		/// <param name="innerException">The exception that is the cause of the current exception.</param>
		public BasicParserException(string message, Exception innerException) : base(message, innerException) {}
	}

	#endregion
}