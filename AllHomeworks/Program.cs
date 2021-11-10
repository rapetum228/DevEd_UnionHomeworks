using Lists;

namespace AllHomeworks
{
    class Program
    {
        static void Main(string[] args)
        {

            LinkedList<string> intLinkedList = new LinkedList<string>(new string[] 
            { "qwerty", "df", "wer" });
            int a = 42;
            intLinkedList.AddFirst("aaaaaaaaaaaaaaa");
            intLinkedList.Sort();

        }
    }
}
