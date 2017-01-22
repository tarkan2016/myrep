using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Windows.Forms;
namespace Dentistry
{
    class XmlClass
    {
        public static Boolean ReadXML()
        {
            try
            {
                string sStartupPath = Application.StartupPath;
                using (XmlTextReader objXmlTextReader = new XmlTextReader(sStartupPath + @"\Setting.xml"))
                {
                    string sName = "";
                    while (objXmlTextReader.Read())
                    {
                        switch (objXmlTextReader.NodeType)
                        {
                            case XmlNodeType.Element:
                                sName = objXmlTextReader.Name;
                                break;
                            case XmlNodeType.Text:
                                switch (sName)
                                {
                                    case "CompanyName":
                                        Vars.CompanyName = objXmlTextReader.Value;
                                        break;
                                    case "LatinCompanyName":
                                        Vars.LatinCompanyName = objXmlTextReader.Value;
                                        break;
                                    case "Address":
                                        Vars.Address = objXmlTextReader.Value;
                                        break;
                                    case "ZipCode":
                                        Vars.zipcode = objXmlTextReader.Value;
                                        break;
                                    case "Tel1":
                                        Vars.Tel1 = objXmlTextReader.Value;
                                        break;
                                    case "Tel2":
                                        Vars.Tel2 = objXmlTextReader.Value;
                                        break;
                                    case "FishPrinter":
                                        Vars.FishPrinter = objXmlTextReader.Value;
                                        break;
                                    case "BarCodePrinter":
                                        Vars.BarCodePrinter = objXmlTextReader.Value;
                                        break;
                                    case "A4Printer":
                                        Vars.A4Printer = objXmlTextReader.Value;
                                        break;
                                    case "BackupPath":
                                        Vars.BackupPath = objXmlTextReader.Value;
                                        break;
                                    case "BackGroundImage":
                                        Vars.BackGroundImage = objXmlTextReader.Value;
                                        break;
                                    case "LogoImage":
                                        Vars.LogoImage = objXmlTextReader.Value;
                                        break;
                                    case "NameLogoImage":
                                        Vars.NameLogoImage = objXmlTextReader.Value;
                                        break;
                                    case "isAutoRecord":
                                        Vars.isAutoRecord = Convert.ToBoolean(objXmlTextReader.Value);
                                        break;
                                    case "CodeKAuto":
                                        Vars.CodeKAuto = Convert.ToBoolean(objXmlTextReader.Value);
                                        break;
                                    case "DefaultFactorFPage":
                                        Vars.DefaultFactorFPage = objXmlTextReader.Value;
                                        break;
                                    case "Server":
                                        Vars.server = objXmlTextReader.Value;
                                        break;
                                    case "dbName":
                                        //Vars.dbname  = objXmlTextReader.Value;
                                        break;
                                    case "dbUser":
                                        Vars.dbuser = objXmlTextReader.Value;
                                        break;
                                    case "dbPassword":
                                        Vars.dbPassword = objXmlTextReader.Value;
                                        break;
                                    case "ColCodeBed":
                                        Vars.ColCodeBed = objXmlTextReader.Value;
                                        break;
                                    case "ColCodeBes":
                                        Vars.ColCodeBes = objXmlTextReader.Value;
                                        break;
                                    case "ColCodeSell":
                                        Vars.ColCodeSell = objXmlTextReader.Value;
                                        break;
                                    case "MoenCodeSell":
                                        Vars.MoenCodeSell = objXmlTextReader.Value;
                                        break;
                                    case "ColCodeBSell":
                                        Vars.ColCodeBSell = objXmlTextReader.Value;
                                        break;
                                    case "MoenCodeBsell":
                                        Vars.MoenCodeBSell = objXmlTextReader.Value;
                                        break;
                                    case "ColCodeKh":
                                        Vars.colCodeKH = objXmlTextReader.Value;
                                        break;
                                    case "MoenCodeKH":
                                        Vars.MoenCodeKH = objXmlTextReader.Value;
                                        break;
                                    case "ColCodeBKH":
                                        Vars.ColCodeBKH = objXmlTextReader.Value;
                                        break;
                                    case "MoenCodeBKH":
                                        Vars.MoenCodeBKH = objXmlTextReader.Value;
                                        break;
                                    case "ColCodeSandoq":
                                        Vars.ColCodeSandoq = objXmlTextReader.Value;
                                        break;
                                    case "ColCodeBank":
                                        Vars.ColCodeBank = objXmlTextReader.Value;
                                        break;
                                    case "coLCodeHazine":
                                        Vars.ColCodeHazine = objXmlTextReader.Value;
                                        break;
                                    case "MoenCodeHazine":
                                        Vars.MoenCodeHazine = objXmlTextReader.Value;
                                        break;
                                    case "coLCodeDaramad":
                                        Vars.ColCodeDaramad = objXmlTextReader.Value;
                                        break;
                                    case "MoenCodeDaramad":
                                        Vars.MoenCodeDaramad = objXmlTextReader.Value;
                                        break;
                                    case "ColCodeAsnadDaryafti":
                                        Vars.ColCodeAsnadDaryafti = objXmlTextReader.Value;
                                        break;
                                    case "MoenCodeAsnadDaryafti":
                                        Vars.MoenCodeAsnadDaryaftani = objXmlTextReader.Value;
                                        break;
                                    case "coLCodeAsnadPardakhti":
                                        Vars.ColCodeAsnadPardakhti = objXmlTextReader.Value;
                                        break;
                                    case "MoenCodeAsnadPardakhti":
                                        Vars.MoenCodeAsnadPardakhtani = objXmlTextReader.Value;
                                        break;
                                    case "MoenCodeBargashtiNS":
                                        Vars.MoenCodeBargashtiNS = objXmlTextReader.Value;
                                        break;
                                    case "coLCodeMal":
                                        Vars.ColCodeMal = objXmlTextReader.Value;
                                        break;
                                    case "moenCodeMal":
                                        Vars.MoenCodeMal = objXmlTextReader.Value;
                                        break;
                                    case "coLCodeAv":
                                        Vars.ColCodeAv  = objXmlTextReader.Value;
                                        break;
                                    case "MoenCodeAv":
                                        Vars.MoenCodeAv = objXmlTextReader.Value;
                                        break;

                                    case "coLCodeKHMal":
                                        Vars.ColCodeKHMal = objXmlTextReader.Value;
                                        break;
                                    case "moenCodeKHMal":
                                        Vars.MoenCodeKHMal = objXmlTextReader.Value;
                                        break;
                                    case "coLCodeKHAv":
                                        Vars.ColCodeKHAv = objXmlTextReader.Value;
                                        break;
                                    case "MoenCodeKHAv":
                                        Vars.MoenCodeKHAv = objXmlTextReader.Value;
                                        break;

                                    case "TakhfifF":
                                        Vars.SellTakhfif = objXmlTextReader.Value;
                                        break;
                                    case "TakhfifBF":
                                        Vars.BSellTakhfif = objXmlTextReader.Value;
                                        break;
                                    case "TakhfifK":
                                        Vars.BuyTakhfif = objXmlTextReader.Value;
                                        break;

                                    case "TakhfifBKH":
                                        Vars.BBuyeTakhfif = objXmlTextReader.Value;
                                        break;

                                    case "AutoSanad":
                                        Vars.AutoSanad = Convert.ToBoolean (objXmlTextReader.Value);
                                        break;
                                    case "codeMotafareqe":
                                        Vars.codeMotafareqe  = objXmlTextReader.Value;
                                        break;
                                    case "codeCityMotafareqe":
                                        Vars.codeCityMotafareqe = objXmlTextReader.Value;
                                        break;

                                    case "DomainName":
                                        Vars.DomainName = objXmlTextReader.Value;
                                        break;
                                    case "DomaniUserName":
                                        Vars.DomainUserName = objXmlTextReader.Value;
                                        break;
                                    case "DomainPass":
                                        Vars.DomainPass = objXmlTextReader.Value;
                                        break;

                                    case "StartTime":
                                        Vars.StartTime = objXmlTextReader.Value;
                                        break;

                                    case "EndTime":
                                        Vars.EndTime = objXmlTextReader.Value;
                                        break;
                                    case "FactorfMessage":
                                        Vars.FactorfMessage = objXmlTextReader.Value;
                                        break;
                                    case "ChangePrice":
                                        Vars.ChangePrice = objXmlTextReader.Value;
                                        break;

                                    case "Checkr":
                                        Vars.Checkr = objXmlTextReader.Value;
                                        break;


                                    case "CheckB":
                                        Vars.CheckB = objXmlTextReader.Value;
                                        break;



                                    case "CheckBeforDater":
                                        Vars.CheckBeforDater = objXmlTextReader.Value;
                                        break;

                                    case "PriceC":
                                        Vars.PriceC = objXmlTextReader.Value;
                                        break;

                                    case "Priceb":
                                        Vars.Priceb = objXmlTextReader.Value;
                                        break;
                                    case "MandeMessage":
                                        Vars.MandeMessage = objXmlTextReader.Value;
                                        break;
                                    case "VisitorSell":
                                        Vars.VisitorSell = objXmlTextReader.Value;
                                        break;

                                    case "Modirpass":
                                        Vars.Modirpass = objXmlTextReader.Value;
                                        break;

                                    case "DMAl":
                                       // Vars.DMAl = objXmlTextReader.Value;
                                        break;

                                    case "DAv":
                                        //Vars.DAv = objXmlTextReader.Value;
                                        break;

                                    case "TafzilyCode":
                                        Vars.TafzilyCode  = objXmlTextReader.Value;
                                        break;

                                    case "PriceHad":
                                        Vars.PriceHad  = objXmlTextReader.Value;
                                        break;

                                    case "ChekUser":
                                        Vars.ChkUser = Convert .ToBoolean(objXmlTextReader.Value);
                                        break;


                                    case "Fcode":
                                        Vars.Fcode = Convert.ToBoolean(objXmlTextReader.Value);
                                        break;

                                    case "Gqati":
                                        Vars.Gqati = Convert.ToBoolean(objXmlTextReader.Value);
                                        break;

                                    case "CodeMaliyatKharid":
                                        Vars.CodeMaliyatkharid = objXmlTextReader.Value;
                                        break;

                                    case "codehazineKharid":
                                        Vars.Codehazinekharid = objXmlTextReader.Value;
                                        break;

                                }
                                break;
                        }
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return false;
            }
        }
        public static Boolean WriteXML()
        {
            try
            { 
                string sStartupPath = Application.StartupPath;
                using (XmlTextWriter objXmlTextWriter = new XmlTextWriter(sStartupPath + @"\Setting.xml", null))
                {
                    objXmlTextWriter.Formatting = Formatting.Indented;

                    objXmlTextWriter.WriteStartDocument();
                    objXmlTextWriter.WriteStartElement("Values");
                    objXmlTextWriter.WriteStartElement("CompanyName");
                    objXmlTextWriter.WriteString(Vars.CompanyName);
                    objXmlTextWriter.WriteEndElement();

                    objXmlTextWriter.WriteStartElement("LatinCompanyName");
                    objXmlTextWriter.WriteString(Vars.LatinCompanyName);
                    objXmlTextWriter.WriteEndElement();

                    objXmlTextWriter.WriteStartElement("Address");
                    objXmlTextWriter.WriteString(Vars.Address);
                    objXmlTextWriter.WriteEndElement();

                    objXmlTextWriter.WriteStartElement("ZipCode");
                    objXmlTextWriter.WriteString(Vars.zipcode);
                    objXmlTextWriter.WriteEndElement();

                    objXmlTextWriter.WriteStartElement("Tel1");
                    objXmlTextWriter.WriteString(Vars.Tel1);
                    objXmlTextWriter.WriteEndElement();

                    objXmlTextWriter.WriteStartElement("Tel2");
                    objXmlTextWriter.WriteString(Vars.Tel2);
                    objXmlTextWriter.WriteEndElement();

                    objXmlTextWriter.WriteStartElement("FishPrinter");
                    objXmlTextWriter.WriteString(Vars.FishPrinter);
                    objXmlTextWriter.WriteEndElement();

                    objXmlTextWriter.WriteStartElement("BarCodePrinter");
                    objXmlTextWriter.WriteString(Vars.BarCodePrinter);
                    objXmlTextWriter.WriteEndElement();

                    objXmlTextWriter.WriteStartElement("DotMatrixPrinter");
                    objXmlTextWriter.WriteString(Vars.DotMatrixPrinter);
                    objXmlTextWriter.WriteEndElement();

                    objXmlTextWriter.WriteStartElement("A4Printer");
                    objXmlTextWriter.WriteString(Vars.A4Printer);
                    objXmlTextWriter.WriteEndElement();

                    objXmlTextWriter.WriteStartElement("BackGroundImage");
                    objXmlTextWriter.WriteString(Vars.BackGroundImage);
                    objXmlTextWriter.WriteEndElement();

                    objXmlTextWriter.WriteStartElement("BackupPath");
                    objXmlTextWriter.WriteString(Vars.BackupPath);
                    objXmlTextWriter.WriteEndElement();

                    objXmlTextWriter.WriteStartElement("LogoImage");
                    objXmlTextWriter.WriteString(Vars.LogoImage);
                    objXmlTextWriter.WriteEndElement();

                    objXmlTextWriter.WriteStartElement("NameLogoImage");
                    objXmlTextWriter.WriteString(Vars.NameLogoImage);
                    objXmlTextWriter.WriteEndElement();

                    objXmlTextWriter.WriteStartElement("isAutoRecord");
                    objXmlTextWriter.WriteString(Vars.isAutoRecord.ToString());
                    objXmlTextWriter.WriteEndElement();

                    objXmlTextWriter.WriteStartElement("DefaultFactorFPage");
                    objXmlTextWriter.WriteString(Vars.DefaultFactorFPage);
                    objXmlTextWriter.WriteEndElement();

                    objXmlTextWriter.WriteStartElement("Server");
                    objXmlTextWriter.WriteString(Vars.server);
                    objXmlTextWriter.WriteEndElement();

                    objXmlTextWriter.WriteStartElement("dbName");
                    objXmlTextWriter.WriteString(Vars.dbname);
                    objXmlTextWriter.WriteEndElement();

                    objXmlTextWriter.WriteStartElement("dbUser");
                    objXmlTextWriter.WriteString(Vars.dbuser);
                    objXmlTextWriter.WriteEndElement();

                    objXmlTextWriter.WriteStartElement("dbPassword");
                    objXmlTextWriter.WriteString(Vars.dbPassword);
                    objXmlTextWriter.WriteEndElement();

                    objXmlTextWriter.WriteStartElement("ColCodeBed");
                    objXmlTextWriter.WriteString(Vars.ColCodeBed );
                    objXmlTextWriter.WriteEndElement();

                    objXmlTextWriter.WriteStartElement("ColCodeBes");
                    objXmlTextWriter.WriteString(Vars.ColCodeBes);
                    objXmlTextWriter.WriteEndElement();

                    objXmlTextWriter.WriteStartElement("ColCodeSell");
                    objXmlTextWriter.WriteString(Vars.ColCodeSell);
                    objXmlTextWriter.WriteEndElement();

                    objXmlTextWriter.WriteStartElement("MoenCodeSell");
                    objXmlTextWriter.WriteString(Vars.MoenCodeSell);
                    objXmlTextWriter.WriteEndElement();

                    objXmlTextWriter.WriteStartElement("ColCodeBSell");
                    objXmlTextWriter.WriteString(Vars.ColCodeBSell );
                    objXmlTextWriter.WriteEndElement();

                    objXmlTextWriter.WriteStartElement("MoenCodeBsell");
                    objXmlTextWriter.WriteString(Vars.MoenCodeBSell );
                    objXmlTextWriter.WriteEndElement();

                    objXmlTextWriter.WriteStartElement("ColCodeKh");
                    objXmlTextWriter.WriteString(Vars.colCodeKH );
                    objXmlTextWriter.WriteEndElement();

                    objXmlTextWriter.WriteStartElement("MoenCodeKH");
                    objXmlTextWriter.WriteString(Vars.MoenCodeKH );
                    objXmlTextWriter.WriteEndElement();

                    objXmlTextWriter.WriteStartElement("ColCodeBKH");
                    objXmlTextWriter.WriteString(Vars.ColCodeBKH);
                    objXmlTextWriter.WriteEndElement();

                    objXmlTextWriter.WriteStartElement("MoenCodeBKH");
                    objXmlTextWriter.WriteString(Vars.MoenCodeBKH );
                    objXmlTextWriter.WriteEndElement();

                    objXmlTextWriter.WriteStartElement("ColCodeSandoq");
                    objXmlTextWriter.WriteString(Vars.ColCodeSandoq );
                    objXmlTextWriter.WriteEndElement();

                    objXmlTextWriter.WriteStartElement("ColCodeBank");
                    objXmlTextWriter.WriteString(Vars.ColCodeBank );
                    objXmlTextWriter.WriteEndElement();

                    objXmlTextWriter.WriteStartElement("coLCodeHazine");
                    objXmlTextWriter.WriteString(Vars.ColCodeHazine );
                    objXmlTextWriter.WriteEndElement();

                    objXmlTextWriter.WriteStartElement("MoenCodeHazine");
                    objXmlTextWriter.WriteString(Vars.MoenCodeHazine);
                    objXmlTextWriter.WriteEndElement();

                    objXmlTextWriter.WriteStartElement("coLCodeDaramad");
                    objXmlTextWriter.WriteString(Vars.ColCodeDaramad);
                    objXmlTextWriter.WriteEndElement();

                    objXmlTextWriter.WriteStartElement("MoenCodeDaramad");
                    objXmlTextWriter.WriteString(Vars.MoenCodeDaramad);
                    objXmlTextWriter.WriteEndElement();

                    objXmlTextWriter.WriteStartElement("ColCodeAsnadDaryafti");
                    objXmlTextWriter.WriteString(Vars.ColCodeAsnadDaryafti);
                    objXmlTextWriter.WriteEndElement();

                    objXmlTextWriter.WriteStartElement("MoenCodeAsnadDaryafti");
                    objXmlTextWriter.WriteString(Vars.MoenCodeAsnadDaryaftani);
                    objXmlTextWriter.WriteEndElement();

                    objXmlTextWriter.WriteStartElement("coLCodeAsnadPardakhti");
                    objXmlTextWriter.WriteString(Vars.ColCodeAsnadPardakhti);
                    objXmlTextWriter.WriteEndElement();

                    objXmlTextWriter.WriteStartElement("MoenCodeAsnadPardakhti");
                    objXmlTextWriter.WriteString(Vars.MoenCodeAsnadPardakhtani );
                    objXmlTextWriter.WriteEndElement();

                    objXmlTextWriter.WriteStartElement("MoenCodeBargashtiNS");
                    objXmlTextWriter.WriteString(Vars.MoenCodeBargashtiNS);
                    objXmlTextWriter.WriteEndElement();

                    objXmlTextWriter.WriteStartElement("coLCodeMal");
                    objXmlTextWriter.WriteString(Vars.ColCodeMal);
                    objXmlTextWriter.WriteEndElement();

                    objXmlTextWriter.WriteStartElement("moenCodeMal");
                    objXmlTextWriter.WriteString(Vars.MoenCodeMal);
                    objXmlTextWriter.WriteEndElement();

                    objXmlTextWriter.WriteStartElement("coLCodeAv");
                    objXmlTextWriter.WriteString(Vars.ColCodeAv );
                    objXmlTextWriter.WriteEndElement();

                    objXmlTextWriter.WriteStartElement("MoenCodeAv");
                    objXmlTextWriter.WriteString(Vars.MoenCodeAv );
                    objXmlTextWriter.WriteEndElement();

                    objXmlTextWriter.WriteStartElement("coLCodeKHMal");
                    objXmlTextWriter.WriteString(Vars.ColCodeKHMal);
                    objXmlTextWriter.WriteEndElement();

                    objXmlTextWriter.WriteStartElement("moenCodeKHMal");
                    objXmlTextWriter.WriteString(Vars.MoenCodeKHMal);
                    objXmlTextWriter.WriteEndElement();

                    objXmlTextWriter.WriteStartElement("coLCodeKHAv");
                    objXmlTextWriter.WriteString(Vars.ColCodeKHAv);
                    objXmlTextWriter.WriteEndElement();

                    objXmlTextWriter.WriteStartElement("MoenCodeKHAv");
                    objXmlTextWriter.WriteString(Vars.MoenCodeKHAv);
                    objXmlTextWriter.WriteEndElement();

                    objXmlTextWriter.WriteStartElement("TakhfifF");
                    objXmlTextWriter.WriteString(Vars.SellTakhfif );
                    objXmlTextWriter.WriteEndElement();

                    objXmlTextWriter.WriteStartElement("TakhfifBF");
                    objXmlTextWriter.WriteString(Vars.BSellTakhfif);
                    objXmlTextWriter.WriteEndElement();

                    objXmlTextWriter.WriteStartElement("TakhfifK");
                    objXmlTextWriter.WriteString(Vars.BuyTakhfif);
                    objXmlTextWriter.WriteEndElement();

                    objXmlTextWriter.WriteStartElement("TakhfifBKH");
                    objXmlTextWriter.WriteString(Vars.BBuyeTakhfif);
                    objXmlTextWriter.WriteEndElement();

                    objXmlTextWriter.WriteStartElement("AutoSanad");
                    objXmlTextWriter.WriteString(Convert.ToString (Vars.AutoSanad));
                    objXmlTextWriter.WriteEndElement();

                    objXmlTextWriter.WriteStartElement("codeMotafareqe");
                    objXmlTextWriter.WriteString(Convert.ToString(Vars.codeMotafareqe  ));
                    objXmlTextWriter.WriteEndElement();

                    objXmlTextWriter.WriteStartElement("codeCityMotafareqe");
                    objXmlTextWriter.WriteString(Convert.ToString(Vars.codeCityMotafareqe));
                    objXmlTextWriter.WriteEndElement();



                    objXmlTextWriter.WriteStartElement("StartTime");
                    objXmlTextWriter.WriteString(Vars.StartTime);
                    objXmlTextWriter.WriteEndElement();


                    objXmlTextWriter.WriteStartElement("EndTime");
                    objXmlTextWriter.WriteString(Vars.EndTime);
                    objXmlTextWriter.WriteEndElement();

                    objXmlTextWriter.WriteStartElement("DomainName");
                    objXmlTextWriter.WriteString(Vars.DomainName);
                    objXmlTextWriter.WriteEndElement();

                    objXmlTextWriter.WriteStartElement("DomaniUserName");
                    objXmlTextWriter.WriteString(Vars.DomainUserName);
                    objXmlTextWriter.WriteEndElement();

                    objXmlTextWriter.WriteStartElement("DomainPass");
                    objXmlTextWriter.WriteString(Vars.DomainPass);
                    objXmlTextWriter.WriteEndElement();

                    objXmlTextWriter.WriteStartElement("FactorfMessage");
                    objXmlTextWriter.WriteString(Vars.FactorfMessage);
                    objXmlTextWriter.WriteEndElement();

                    objXmlTextWriter.WriteStartElement("ChangePrice");
                    objXmlTextWriter.WriteString(Vars.ChangePrice);
                    objXmlTextWriter.WriteEndElement();

                    objXmlTextWriter.WriteStartElement("Checkr");
                    objXmlTextWriter.WriteString(Vars.Checkr);
                    objXmlTextWriter.WriteEndElement();

                    objXmlTextWriter.WriteStartElement("CheckB");
                    objXmlTextWriter.WriteString(Vars.CheckB);
                    objXmlTextWriter.WriteEndElement();

                    objXmlTextWriter.WriteStartElement("CheckBeforDater");
                    objXmlTextWriter.WriteString(Vars.CheckBeforDater);
                    objXmlTextWriter.WriteEndElement();

                    objXmlTextWriter.WriteStartElement("MandeMessage");
                    objXmlTextWriter.WriteString(Vars.MandeMessage);
                    objXmlTextWriter.WriteEndElement();

                    objXmlTextWriter.WriteStartElement("VisitorSell");
                    objXmlTextWriter.WriteString(Vars.VisitorSell);
                    objXmlTextWriter.WriteEndElement();

                    objXmlTextWriter.WriteStartElement("PriceC");
                    objXmlTextWriter.WriteString(Vars.PriceC);
                    objXmlTextWriter.WriteEndElement();

                    objXmlTextWriter.WriteStartElement("Priceb");
                    objXmlTextWriter.WriteString(Vars.Priceb);
                    objXmlTextWriter.WriteEndElement();

                    objXmlTextWriter.WriteStartElement("Modirpass");
                    objXmlTextWriter.WriteString(Vars.Modirpass);
                    objXmlTextWriter.WriteEndElement();

                    objXmlTextWriter.WriteStartElement("DMAl");
                    objXmlTextWriter.WriteString(Vars.DMAl);
                    objXmlTextWriter.WriteEndElement();

                    objXmlTextWriter.WriteStartElement("DAv");
                    objXmlTextWriter.WriteString(Vars.DAv);
                    objXmlTextWriter.WriteEndElement();

                    objXmlTextWriter.WriteStartElement("TafzilyCode");
                    objXmlTextWriter.WriteString(Vars.TafzilyCode);
                    objXmlTextWriter.WriteEndElement();

                    objXmlTextWriter.WriteStartElement("PriceHad");
                    objXmlTextWriter.WriteString(Vars.PriceHad);
                    objXmlTextWriter.WriteEndElement();

                    objXmlTextWriter.WriteStartElement("ChekUser");
                    objXmlTextWriter.WriteString(Vars.ChkUser.ToString());
                    objXmlTextWriter.WriteEndElement();

                    objXmlTextWriter.WriteStartElement("Fcode");
                    objXmlTextWriter.WriteString(Convert.ToString(Vars.Fcode));
                    objXmlTextWriter.WriteEndElement();

                    objXmlTextWriter.WriteStartElement("Gqati");
                    objXmlTextWriter.WriteString(Vars.Gqati.ToString());
                    objXmlTextWriter.WriteEndElement();

                    objXmlTextWriter.WriteStartElement("CodeMaliyatKharid");
                    objXmlTextWriter.WriteString(Convert.ToString(Vars.CodeMaliyatkharid));
                    objXmlTextWriter.WriteEndElement();

                    objXmlTextWriter.WriteStartElement("codehazineKharid");
                    objXmlTextWriter.WriteString(Vars.Codehazinekharid.ToString());
                    objXmlTextWriter.WriteEndElement();
                    //CodeKAuto
                    
                    objXmlTextWriter.WriteStartElement("CodeKAuto");
                    objXmlTextWriter.WriteString(Vars.CodeKAuto.ToString());
                    objXmlTextWriter.WriteEndElement(); 

                   // objXmlTextWriter.WriteEndElement(); 
                   objXmlTextWriter.WriteEndElement();
                   objXmlTextWriter.WriteEndDocument();
                    objXmlTextWriter.Flush();
                    objXmlTextWriter.Close();
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return false;
            }

        }
    }

}
