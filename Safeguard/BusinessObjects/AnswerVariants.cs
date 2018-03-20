using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Xml.Serialization;
using System.IO;

namespace Safeguard.BusinessObjects
{
    [Serializable]
    public class AnswerVariants
    {
        List<string> answerList;

        public AnswerVariants()
            : this(null)
        {
        }

        public AnswerVariants(List<string> answerList = null)
        {
            this.List = answerList;
        }

        public void Add(string answer)
        {
            this.answerList.Add(answer);
        }

        public List<string> List
        {
            get { return this.answerList; }
            set
            {
                this.answerList = value ?? new List<string>();
            }
        }

        /// <summary>
        /// Serialize object AnswerVariants to string contains xml-data
        /// </summary>
        /// <param name="answerVariants"></param>
        /// <returns></returns>
        public static string SaveToXmlString(AnswerVariants answerVariants)
        {            
            string result = string.Empty;

            XmlSerializer xmlFormat = new XmlSerializer(typeof(AnswerVariants));
            using (System.IO.TextWriter stream = new System.IO.StringWriter())
            {
                using (System.Xml.XmlWriter strim = new System.Xml.XmlTextWriter(stream))
                {
                    xmlFormat.Serialize(strim, answerVariants);
                }
                result = stream.ToString();
            }
            return result;
        }

        /// <summary>
        /// Deserialize object from string contains xml-data
        /// </summary>
        /// <param name="xml"></param>
        /// <returns></returns>
        public static AnswerVariants RestoreFromXmlString(string xml)
        {    
            AnswerVariants answerVariants = null;

            //если поле в базе данных не инициализировано поле
            if (xml == null || xml == string.Empty)
            {
                answerVariants = new AnswerVariants(); 
            }
            else
            {
                XmlSerializer xmlFormat = new XmlSerializer(typeof(AnswerVariants));
                using (System.IO.TextReader stream = new System.IO.StringReader(xml))
                {
                    using (System.Xml.XmlReader strim = new System.Xml.XmlTextReader(stream))
                    {
                        //if (xmlFormat.CanDeserialize(strim) == true)
                        {
                            answerVariants = (AnswerVariants)xmlFormat.Deserialize(strim);
                        }
                    }
                }
            }

            return answerVariants;
        }
        /*
        //Вариант 3 неправильный
        //запись в память и потом в строку
        System.IO.Stream stream4 = new System.IO.MemoryStream();
        string s = string.Empty;
        using (System.Xml.XmlWriter fStrim = new System.Xml.XmlTextWriter(stream4, System.Text.Encoding.UTF8))
        {
            xmlFormat.Serialize(fStrim, answerVariants);

            stream4.Seek(0, System.IO.SeekOrigin.Begin);
            byte[] b = new byte[stream4.Length];
            stream4.Read(b, 0, (int)stream4.Length);

            System.Text.UTF8Encoding enc = new System.Text.UTF8Encoding();
            s = enc.GetString(b);
        }

        //чтение из строки в память, а потом восстановление
        System.IO.Stream stream5 = new System.IO.MemoryStream();
        System.Text.UTF8Encoding enc2 = new System.Text.UTF8Encoding();
        byte [] dBytes = enc2.GetBytes(s);
        stream5.Write(dBytes, 0, dBytes.Length);
        stream5.Seek(0, System.IO.SeekOrigin.Begin);
        using (System.Xml.XmlReader fStrim = new System.Xml.XmlTextReader(stream5))
        {
            variants2 = (AnswerVariants)xmlFormat.Deserialize(fStrim);
        }

        //Вариант 4 более правильный, но мудёжный по сравнению с 1 и 2-м
        using (System.IO.Stream mstream = new System.IO.MemoryStream())
        {
            xmlFormat.Serialize(mstream, answerVariants);

            mstream.Seek(0, System.IO.SeekOrigin.Begin);
            byte[] b = new byte[mstream.Length];
            mstream.Read(b, 0, (int)mstream.Length);

            System.Text.UTF8Encoding enc = new System.Text.UTF8Encoding();
            s = enc.GetString(b);
        }

        using (System.IO.Stream mstream = new System.IO.MemoryStream())
        {
            //System.Text.UTF8Encoding enc2 = new System.Text.UTF8Encoding();
            //byte[] dBytes = enc2.GetBytes(s);
            mstream.Write(dBytes, 0, dBytes.Length);
            mstream.Seek(0, System.IO.SeekOrigin.Begin);
            variants2 = (AnswerVariants)xmlFormat.Deserialize(mstream);
        }
        */

        /*//Вариант 1. запись в файл
        using (System.IO.Stream fStrim = new System.IO.FileStream("d:\\answers_file.xml", System.IO.FileMode.Create, System.IO.FileAccess.Write))
        {
            xmlFormat.Serialize(fStrim, answerVariants);
        }
        using (System.IO.TextWriter fStrim = new System.IO.StreamWriter("d:\\answers_text.xml"))
        {
            xmlFormat.Serialize(fStrim, answerVariants);
        }
        using (System.Xml.XmlWriter fStrim = new System.Xml.XmlTextWriter("d:\\answers_xml.xml", System.Text.Encoding.UTF8))
        {
            xmlFormat.Serialize(fStrim, answerVariants);
        }
         
        //чтение из файла
        AnswerVariants variants = null;
        using (System.IO.Stream fStrim = new System.IO.FileStream("d:\\answers_xml.xml", System.IO.FileMode.Open, System.IO.FileAccess.Read))
        {
            variants = (AnswerVariants)xmlFormat.Deserialize(fStrim);
        }
        */

    }
}
