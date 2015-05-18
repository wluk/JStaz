using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ErrorCode
{
    class Program
    {
        const string address = "http://localhost:64643/";

        static void Main(string[] args)
        {
            do
            {
                if (DateTime.Now.Second % 5 == 0)
                {
                    Console.WriteLine("Req no. 1 - " + DateTime.Now.ToLongTimeString());
                    var req1 = NetWebException(address);
                    Thread.Sleep(5000);
                    Console.WriteLine("Req no. 2 - " + DateTime.Now.ToLongTimeString());
                    var req2 = NetWebException(address);

                    if (req1 != null && req1.ErrorDescription == req2.ErrorDescription)
                    {
                        Console.WriteLine("\n" + req1.StatusCode + "\n" + req1.StatusDescription + "\n");
                    }
                    else
                    {
                        Console.WriteLine("\nOK\n");
                    }
                    Thread.Sleep(15000);
                }
            } while (true);
        }


        private static ErrorDetail NetWebException(string URL)
        {
            try
            {
                HttpWebRequest myHttpWebRequest = (HttpWebRequest)WebRequest.Create(URL);

                HttpWebResponse myHttpWebResponse = (HttpWebResponse)myHttpWebRequest.GetResponse();
                myHttpWebResponse.Close();
                //Console.WriteLine("OK");
                return null;
            }
            catch (WebException e)
            {
                //Console.WriteLine("This program is expected to throw WebException on successful run." +
                //                    "\n\nException Message :" + e.Message);
                //if (e.Status == WebExceptionStatus.ProtocolError)
                //{
                //    Console.WriteLine("Status Code : {0}", ((HttpWebResponse)e.Response).StatusCode);
                //    Console.WriteLine("Status Description : {0}", ((HttpWebResponse)e.Response).StatusDescription);
                //}
                return new ErrorDetail
                {
                    ErrorDescription = e.Message,
                    StatusCode = (int)((HttpWebResponse)e.Response).StatusCode,
                    StatusDescription = ((HttpWebResponse)e.Response).StatusDescription,
                    ex = e
                };
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return new ErrorDetail
                {
                    ErrorDescription = e.Message,
                    StatusDescription = null,
                    ex = null
                };
            }
        }

        private static void NetHttpWebResponse(string URL)
        {
            HttpWebResponse objResponse = null;
            var objRequest = HttpWebRequest.Create(URL);

            objResponse = (HttpWebResponse)objRequest.GetResponse();
            if (objResponse.StatusCode != HttpStatusCode.OK)
            {
                Console.WriteLine(DateTime.Now.ToLongTimeString() + ": It failed");
            }
            else
            {
                Console.WriteLine(DateTime.Now.ToLongTimeString() + ": It worked");
            }

        }
    }

    class ErrorDetail
    {
        public string ErrorDescription { get; set; }
        public int? StatusCode { get; set; }
        public string StatusDescription { get; set; }

        public WebException ex { get; set; }
    }
}
