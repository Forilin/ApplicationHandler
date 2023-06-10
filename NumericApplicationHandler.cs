using System;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;

 public class NumericApplicationHandler
        {
            private string applicationStr = "";
            HttpApplicationState Application = HttpContext.Current.Application;
            public NumericApplicationHandler(string application)
            {
                this.applicationStr = application;
            }

            public void Set(string value)
            {
                try
                {
                    Application[applicationStr] = Convert.ToInt32(value).ToString();
                } 
                catch (FormatException)
                {
                    return;
                }
            }

            public void SetFromInt(int value)
            {
                Application[applicationStr] = value;
            }

            public int GetAsInt()
            {
                return Convert.ToInt32(Application[applicationStr]);
            }

            public string Get()
            {
                return Application[applicationStr].ToString();
            }

            public int AddOne()
            {
                try
                {
                    Application[applicationStr] = (Convert.ToInt32(Application[applicationStr]) + 1).ToString();
                    return Convert.ToInt32(Application[applicationStr]);
                }
                catch (FormatException)
                {
                    return -1;
                }
            }

            public int RemoveOne()
            {
                try
                {
                    Application[applicationStr] = (Convert.ToInt32(Application[applicationStr]) - 1).ToString();
                    return Convert.ToInt32(Application[applicationStr]);
                }
                catch (FormatException)
                {
                    return -1;
                }
            }

            public void RemoveAtIndex(int index)
            {
                if (index > Application[applicationStr].ToString().Length)
                {
                    return;
                }

                string newString = Application[applicationStr].ToString();

                for (int i = 0; i < Application[applicationStr].ToString().Length; i++)
                {
                    if (i == index) continue;
                    newString += Application[applicationStr];
                }

                Application[applicationStr] = newString;
            }

            public void RemoveLastChar()
            {
                Application[applicationStr] = Application[applicationStr].ToString().Substring(0, Application[applicationStr].ToString().Length - 1);
            }

            public void RemoveFirstChar()
            {
                Application[applicationStr] = Application[applicationStr].ToString().Substring(1);
            }

            public void AddWithInt(int value)
            {
                Application[applicationStr] = Convert.ToInt32(Application[applicationStr].ToString()) + value;
            }

            public void RemoveWithInt(int value)
            {
                Application[applicationStr] = Convert.ToInt32(Application[applicationStr].ToString()) - value;
            }
        }
