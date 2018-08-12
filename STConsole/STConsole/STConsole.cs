using FlaUI.Core;
using FlaUI.UIA3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STConsole
{
    class STConsole
    {
        internal Application app;

        internal UIA3Automation auto;

        internal enum Kind
        {
            XPath = 1,
            ID = 2,
            Name = 3,
            Class = 4,
            Text = 5
        }


        public STConsole()
        {
            var app = Application.Launch("calc.exe");
            using (var automation = new UIA3Automation())
            {
                this.app = app;

                var window = app.GetMainWindow(automation);
                Console.WriteLine(window.Title);
            }
        }

        public void mainMenu()
        {
            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("Choose option:");
                Console.WriteLine("\t1).... Test Selector");
                Console.WriteLine("\t2).... Generate Selector");
                Console.WriteLine("\t3).... Options");
                Console.WriteLine("\t4).... Exit");

                string choice = Console.ReadLine().Trim();
                int choiceInt = 0;
                if (Int32.TryParse(choice, out choiceInt))
                {
                    switch (choiceInt)
                    {
                        case 1:
                            testSelectorMenu();
                            break;
                        case 2:
                            genSelectorMenu();
                            break;
                        case 3:
                            optionsMenu();
                            break;
                        case 4:
                            exit = true;
                            break;
                        default:
                            Errors.wrongNumber(choice);
                            break;
                    }
                }
                else
                {
                    Errors.badInput(choice);
                }

            }
        }

        private void testSelectorMenu()
        {

            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("What type of selector would you like to test?");
                Console.WriteLine("\t1).... XPath");
                Console.WriteLine("\t2).... ID");
                Console.WriteLine("\t3).... Name");
                Console.WriteLine("\t4).... Class");
                Console.WriteLine("\t5).... Text");
                Console.WriteLine("\t5).... Main Menu");

                string choice = Console.ReadLine().Trim();
                int choiceInt = 0;
                if (Int32.TryParse(choice, out choiceInt))
                {
                    switch (choiceInt)
                    {
                        case 1:
                            testSelectorMenu();
                            break;
                        case 2:
                            genSelectorMenu();
                            break;
                        case 3:
                            optionsMenu();
                            break;
                        case 4:
                            exit = true;
                            break;
                        default:
                            Errors.wrongNumber(choice);
                            break;
                    }
                }
                else
                {
                    Errors.badInput(choice);
                }
            }
        }

        private void testSelector(Kind type)
        {

            switch (type)
            {
                case Kind.XPath:
                    break;
                case Kind.ID:
                    break;
                case Kind.Name:
                    break;
                case Kind.Class:
                    break;
                case Kind.Text:
                    break;
            }
        }

        private void genSelectorMenu()
        {
            throw new NotImplementedException();
        }

        private void optionsMenu()
        {
            throw new NotImplementedException();
        }
    }
}