using System.IO;

namespace FlashCardsApp
{
    public class TheHomeCollection
    {
        private string firstLanguage;
        private string secondLanguage;

        public string FirstLanguage
        {
            get { return firstLanguage; }
            set { firstLanguage = value; }
        }
        public string SecondLanguage
        {
            get { return secondLanguage; }
            set { secondLanguage = value; }
        }
        public TheHomeCollection()
        {

        }

        //method to add words to lists from file
        public void AddCollection()
        {
            StreamReader file = new StreamReader("");
            //checking a file
            if (file == null)
                throw new FileNotFoundException("File not found");

            string[] words;
            char[] delimeter = { ',' };
            string line = "";

            //reading a file and adding to lists 
            while ((line = file.ReadLine()) != null)
            {
                words = line.Split(delimeter, 2);

                firstLanguage += words[0];
                secondLanguage += words[1];
            }
            file.Close();
        }

    }
}
