using System;
using System.IO;
using System.Xml;
using System.Xml.Xsl;
using System.Xml.XPath;

public class XmlTransform
{

    public static void Main(string[] args)
    {
        Console.WriteLine("XML Transform (version: 1.3) - Start.");

         if (args.Length == 3)
        {
            Console.WriteLine("Input :" + args[0]);
            Console.WriteLine("Transf:" + args[1]);
            Console.WriteLine("Output:" + args[2]);

            Transform(args[0], args[1], args[2]);
        }
        else
        {
            Console.WriteLine("Usage: input.xml transform.xsl output.xml.");
        }

        Console.WriteLine("XML Transform - END.");
    }

    public static void Transform(string sXmlPath, string sXslPath, string sXmlResult)
    {
        try
        {
            //load the Xml doc
            XPathDocument myXPathDoc = new XPathDocument(sXmlPath);

            //create XslTransform
            System.Xml.Xsl.XslCompiledTransform myXslTrans = new System.Xml.Xsl.XslCompiledTransform();

            //load the Xsl 
            myXslTrans.Load(sXslPath);

            //run transformation 
            myXslTrans.Transform(sXmlPath, sXmlResult);

        }
        catch (Exception e)
        {

            Console.WriteLine("Exception: {0}", e.ToString());
        }

    }

    //public static void TransformA(string sXmlPath, string sXslPath, string sXmlResult)
    //{

    //    try
    //    {
    //        //load the Xml doc
    //        XPathDocument myXPathDoc = new XPathDocument(sXmlPath);

    //        //create XslTransform
    //        XslTransform myXslTrans = new XslTransform();

    //        //load the Xsl 
    //        myXslTrans.Load(sXslPath);


    //        //output settings
    //        //XmlWriterSettings settings = new XmlWriterSettings();
    //        //settings.OmitXmlDeclaration = false;
    //        //settings.Indent = true;
    //        //settings.OutputMethod = XmlOutputMethod.Html;
    //        //settings.OutputMethod = XmlOutputMethod.Xml;
    //        //settings.NewLineChars = Environment.NewLine;
    //        //settings.ConformanceLevel = ConformanceLevel.Document; //.Auto; //.Fragment; //importante
    //        //settings.Encoding = System.Text.Encoding.GetEncoding("ISO-8859-1");

    //        //create the output stream
    //        //XmlTextWriter myWriter = new XmlTextWriter(sXmlResult, null);

    //        // XmlWriter myWriter = XmlTextWriter.Create(sXmlResult); //, settings);
    //        //XmlWriter myWriter = XmlTextWriter.Create(sXmlResult);

    //        //do the actual transform of Xml
    //        //myXslTrans.Transform(myXPathDoc, null, myWriter);
    //        myXslTrans.Transform(sXmlPath, sXmlResult);

    //        //myWriter.Close();
    //    }
    //    catch (Exception e)
    //    {

    //        Console.WriteLine("Exception: {0}", e.ToString());
    //    }

    //}

    //public static void TransformB(string sXmlPath, string sXslPath, string sXmlResult)
    //{

    //    try
    //    {

    //        XslCompiledTransform xslt = new XslCompiledTransform();
    //        xslt.Load(sXslPath);

    //        // Execute the transform and output the results to a file.
    //        xslt.Transform(sXmlPath, sXmlResult);

    //    }
    //    catch (Exception e)
    //    {

    //        Console.WriteLine("Exception: {0}", e.ToString());
    //    }

    //}


}
