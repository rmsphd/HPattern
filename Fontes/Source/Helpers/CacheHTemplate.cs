using System;
using System.Collections.Generic;
using System.Text;
using Artech.Architecture.Common.Objects;
using Artech.Genexus.Common.Objects;

namespace Heurys.Patterns.HPattern.Helpers
{
    public class CacheHTemplate
    {
        private static CacheHTemplate mCache = null;
        private Dictionary<string, CacheVersion> mTemplates = new Dictionary<string, CacheVersion>();
        private KBModel mModelCache = null;
        private int mVersionId = 0;

        public static CacheHTemplate Cache
        {
            get
            {
                if (mCache == null)
                {
                    mCache = new CacheHTemplate();
                }
                return mCache;
            }
        }

        public HTemplate getTemplate(WebPanel webp, ObjTemplate defaultName, KBModel model)
        {
            HTemplate temp = getTemplate(webp, model);
            if (temp == null)
            {
                temp = getTemplate(WebPanel.Get(model, defaultName.ToString()), model);
                if (temp == null && defaultName == ObjTemplate.PromptTemplate)
                {
                    temp = getTemplate(WebPanel.Get(model, ObjTemplate.SelectionTemplate.ToString()), model);
                }
            }
            if (temp == null)
            {
                throw new Artech.Packages.Patterns.PatternException("Template (" + defaultName.ToString() + ") not found!");
            }
            return temp;
        }

        private HTemplate getTemplate(WebPanel webp, KBModel model)
        {
            string chave = "";
            bool expire = false;
            if (webp == null)
            {
                return null;
            }
            else
            {
                chave = webp.Guid.ToString();
            }

            if (mModelCache == null || model == null || !mModelCache.Guid.Equals(model.Guid) || mModelCache.VersionId != model.VersionId || mVersionId != model.VersionId)
            {
                mVersionId = model.VersionId;
                mModelCache = model;
                mTemplates.Clear();
                expire = true;
            } 
            else if (!webp.IsCurrentVersion)
            {
                expire = true;
            }

            if (mTemplates.ContainsKey(chave))
            {
                if (expire == false)
                {
                    CacheVersion cv = mTemplates[chave];
                    if (!cv.Objeto.IsCurrentVersion)
                    {
                        cv.Objeto = webp;
                        cv.Template = new HTemplate(webp.WebForm.EditableContent);
                    }
                    return cv.Template.Clone();
                }
                else
                {
                    mTemplates.Remove(chave);
                }
            }

            HTemplate template = new HTemplate(webp.WebForm.EditableContent);
            mTemplates.Add(chave, new CacheVersion(webp,template));
            return template.Clone();

        }

        public class CacheVersion
        {
            private WebPanel mWebPanel;
            private HTemplate mTemplate;

            public CacheVersion(WebPanel webPanel, HTemplate template)
            {
                mWebPanel = webPanel;
                mTemplate = template;
            }


            public WebPanel Objeto
            {
                get
                {
                    return mWebPanel;
                }
                set
                {
                    mWebPanel = value;
                }
            }

            public HTemplate Template
            {
                get
                {
                    return mTemplate;
                }
                set
                {
                    mTemplate = value;
                }
            }
        }
        

    }


}
