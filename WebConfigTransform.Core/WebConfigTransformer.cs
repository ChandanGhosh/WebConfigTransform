using System.IO;

namespace WebConfigTransform.Core
{
    public static class WebConfigTransformer
    {
        public static string Transform(string webConfigStr, string transformConfigStr, string outputConfigStr, string outPutFileName)
        {
            using (var doc = new Microsoft.Web.XmlTransform.XmlTransformableDocument())
            {
                doc.Load(webConfigStr);

                using (var transform = new Microsoft.Web.XmlTransform.XmlTransformation(transformConfigStr))
                {
                    if (transform.Apply(doc))
                    {
                        if (!Directory.Exists(outputConfigStr))
                        {
                            Directory.CreateDirectory(outputConfigStr);
                        }

                        doc.Save(Path.Combine(outputConfigStr, outPutFileName));

                        return "Transformation successful";

                    }
                    else
                    {
                        return "Transformation failed";
                    }
                }
            }
        }

        public static string Transform(string inputConfig, string transformConfig)
        {
            using (var doc = new Microsoft.Web.XmlTransform.XmlTransformableDocument())
            {
                doc.LoadXml(inputConfig);
                using (var transform = new Microsoft.Web.XmlTransform.XmlTransformation(transformConfig, false, null))
                {
                    if (transform.Apply(doc))
                    {
                        return doc.OuterXml;
                    }
                    else
                    {
                        return "Transformation failed.";
                    }
                }
            }
        }
    }
}
