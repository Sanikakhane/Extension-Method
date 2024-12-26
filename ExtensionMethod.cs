using System;


namespace sample
{
    public static class ExtensionMethods
    {
        //This is normal extension method which we can use as the in built method
        public static void printElement(this List<int> list)
        {
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            // this method implement the default method of the interface
            public static void sleeping(this animal ani)
            {

            }
        }

        public interface animal
        {

        }

        public class dog : animal
        {

        }
    }
}