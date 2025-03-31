using System;

namespace InitOnly
{
    class Transaction // 거래
    {
        public string From { get; init; } // 주는 사람
        public string To { get; init; } // 받는 사람
        public int Amount { get; init; } // 거래량

        public override string ToString()
        {
            return $"{From} -> {To} : ${Amount}";
        }
    }    
    
    class MainApp
    {
        static void Main(string[] args)
        {
            Transaction tr1 = new Transaction { From = "Alice", To = "Bob", Amount = 100 };

            Console.WriteLine(tr1);
            
            // tr1.Amount = 30; // !compile error!
        }
    }
}
// 즉 From, To, Amount는
// "객체생성"할 때 한번 "초기화(init)" 되면
// 다음부터는 외부에서 변경이 불가함