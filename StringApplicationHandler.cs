        public class StringApplicationHandler
        {
            private string applicationStr = "";
            HttpApplicationState Application = HttpContext.Current.Application;
            public StringApplicationHandler(string application)
            {
                this.applicationStr = application;
            }

            public string Get()
            {
                return Application[applicationStr].ToString();
            }

            public void Set(string value)
            {
                Application[applicationStr] = value;
            }

            public void AddChar(char value)
            {
                Application[applicationStr] = Application[applicationStr].ToString() + value;
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
                Application[applicationStr] = Application[applicationStr].ToString().Substring(0, Application[applicationStr].ToString().Length -1);
            }

            public void RemoveFirstChar()
            {
                Application[applicationStr] = Application[applicationStr].ToString().Substring(1);
            }
        }
