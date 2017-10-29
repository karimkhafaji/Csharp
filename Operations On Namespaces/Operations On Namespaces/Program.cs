using static System.Console;
using OF = Friends.OldFriends.MyFriends;
using YF = Friends.YoungFriends.MyFriends;

namespace Operations_On_Namespaces
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Those are My Friends");
            YF.print();
            OF.print();
            ReadKey();
        }
    }
}
