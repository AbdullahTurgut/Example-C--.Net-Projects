using System;
using System.Collections.Generic;

namespace ExampleProject
{


    public class CodeSnippetExamples
    {
        //ctor + tab
        public CodeSnippetExamples()
        {
            //cw  + tab
            Console.WriteLine("Snippets");

            //try + tab
            try
            {

            }
            catch (Exception)
            {

                throw;
            }

            var names = new List<string>();
            foreach (var name in names)
            {

            }

            while (true)
            {

            }

            do
            {

            } while (true);



        }

        //equals + tab
        // override object.Equals
        public override bool Equals(object obj)
        {
            //       
            // See the full list of guidelines at
            //   http://go.microsoft.com/fwlink/?LinkID=85237  
            // and also the guidance for operator== at
            //   http://go.microsoft.com/fwlink/?LinkId=85238
            //

            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            // TODO: write your implementation of Equals() here
            throw new NotImplementedException();
            return base.Equals(obj);
        }

        // override object.GetHashCode
        public override int GetHashCode()
        {
            // TODO: write your implementation of GetHashCode() here
            throw new NotImplementedException();
            return base.GetHashCode();
        }

        //prop + tab
        public string FirstName { get; set; }

        //propfull

        private int _age;

        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }


    }
}
