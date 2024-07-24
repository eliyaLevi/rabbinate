using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using static System.Windows.Forms.LinkLabel;

namespace rabbinate
{
    public partial class Form1 : Form
    {

        //הכרזה על משתנה מסוג xml
        XmlDocument XmlDocument;

        //פתיחת משתנה מסוג סטרינג שמכיל בתוכו את הכתובת של הקובץ xml
        string patName = Directory.GetCurrentDirectory() + "\\rabbinateData.xml";

        public Form1()
        {
            InitializeComponent();

            //פתיחת קובץ מסוג xml
            XmlDocument = new XmlDocument();
            if (File.Exists(patName))
            {
                try
                {
                    XmlDocument.Load(patName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loadingXML file:" + ex.Message);
                }
            }
            else
            {
                XmlNode root = XmlDocument.CreateElement("Queries");
                XmlDocument.AppendChild(root);
                XmlDocument.Save(patName);

            }
            //txtShowAllQuery();
        }

        //Drinks בתוך המסמך של Drink יצירת אובייקט חדש מסוג 
        private void btnWriting_Click(object sender, EventArgs e)
        {
            XmlNode Query = XmlDocument.CreateElement("Query");
            Query.AppendChild(XmlDocument.CreateElement("day")).InnerText = cmdday.Text;
            Query.AppendChild(XmlDocument.CreateElement("DayOfTheMonth")).InnerText = cmbDayOfTheMonth.Text;
            Query.AppendChild(XmlDocument.CreateElement("Month")).InnerText = cmbMonth.Text;
            Query.AppendChild(XmlDocument.CreateElement("year")).InnerText = cmbyear.Text;
            Query.AppendChild(XmlDocument.CreateElement("Results")).InnerText = txtResults.Text;

            XmlDocument.FirstChild.AppendChild(Query);
            XmlDocument.Save(patName);

            PresentDaysInWords();
        }

        //פונקצייה לשמירת המסמך xml
        private void btnSaves_Click(object sender, EventArgs e)
        {
            XmlDocument.Save(patName);
            PresentDaysInWords();
        }

        //פונקציה להציג את הימים
        public void PresentDaysInWords()
        {
         
            foreach (XmlNode Query in XmlDocument.FirstChild.ChildNodes)
            {
                string day = " ", DayOfTheMonth = " ", Month = " ", year = " ", Results = " ";
                foreach (XmlNode node in Query.ChildNodes)
                {
                    if (node.Name == "day")
                    {


                        switch (node.InnerText)
                        {
                            case "ראשון":
                                day = "באחד בשבת";
                                break;

                            case "שני":
                                day = "בשני בשבת";
                                break;

                            case "שלישי":
                                day = "בשלישי בשבת";
                                break;

                            case "רביעי":
                                day = "ברביעי בשבת";
                                break;

                            case "חמישי":
                                day = "בחמישי בשבת";
                                break;

                            case "ששי":
                                day = "בששי בשבת";
                                break;
                        }
                    }
                }
                cmdday.Text = day;
                //dgvDrinksTable.Rows.Add(Name, Sugar, Cofee, koko, Milk, Price);
                
            }
        }

        //פונקציה להציג את הימים בחודש
        public void DisplayDaysOfTheMonth()
        {

            foreach (XmlNode Query in XmlDocument.FirstChild.ChildNodes)
            {
                string day = " ", DayOfTheMonth = " ", Month = " ", year = " ", Results = " ";
                foreach (XmlNode node in Query.ChildNodes)
                {
                    if (node.Name == "DayOfTheMonth")
                    {


                        switch (node.InnerText)
                        {
                            case "1":
                                day = "יום אחד לירח";
                                break;

                            case "2":
                                day = "יום שני לירח";
                                break;

                            case "3":
                                day = "יום שלישי לירח";
                                break;

                        }
                    }
                }
                cmbDayOfTheMonth.Text = DayOfTheMonth;
                //dgvDrinksTable.Rows.Add(Name, Sugar, Cofee, koko, Milk, Price);

            }
        }

        //פונקציה להציג את השנה
        public void shwoYear()
        {

            foreach (XmlNode Query in XmlDocument.FirstChild.ChildNodes)
            {
                string day = " ", DayOfTheMonth = " ", Month = " ", year = " ", Results = " ";
                foreach (XmlNode node in Query.ChildNodes)
                {
                    if (node.Name == "year")
                    {

                        switch (node.InnerText)
                        {
                            case "תשפד":
                                day = "שנת חמשת אלפים ושבע מאות שמונים וארבע לבריאת העולם ";
                                break;

                        }
                    }
                }
                cmbyear.Text = year;


            }
        }
        //פונקציה להציג את התוצאות
        public void shwoResults()
        {
            foreach (XmlNode Query in XmlDocument.FirstChild.ChildNodes)
            {
             
                txtResults.Text = 


            }
        }



    }
}
