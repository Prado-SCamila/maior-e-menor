using System;

namespace maior_e_menor
{
    class Program
    {
        static void Main(string[] args)
        {   
            int[] num = new int[10];

            for(var i=0;i<10;i++){

            Console.WriteLine("Digite 10 números");
            num[i] = int.Parse(Console.ReadLine());
            }
            if(num[0]< num[1] && num[0]< num[2] && num[0]<num[3] && num[0]<num[4] && num[0]<num[5] && num[0]<num[6] && num[0]<num[7] && num[0]<num[8] && num[0]<num[9]){
                Console.WriteLine("O menor número é: "+num[0]);
            }else if(num[1]< num[0] && num[1]< num[2] && num[1]<num[3] && num[1]<num[4] && num[1]<num[5] && num[1]<num[6] && num[1]<num[7] && num[1]<num[8] && num[1]<num[9]){
                  Console.WriteLine("O menor número é: "+num[1]);
            }else if(num[2]< num[0] && num[2]< num[1] && num[2]<num[3] && num[2]<num[4] && num[2]<num[5] && num[2]<num[6] && num[2]<num[7] && num[2]<num[8] && num[2]<num[9]){
                Console.WriteLine("O menor número é: "+num[2]);
            }else if(num[3]< num[0] && num[3]< num[1] && num[3]<num[2] && num[3]<num[4] && num[3]<num[5] && num[3]<num[6] && num[3]<num[7] && num[3]<num[8] && num[3]<num[9]){
                Console.WriteLine("O menor número é: "+num[3]);}
            else if(num[4]< num[0] && num[4]< num[1] && num[4]<num[2] && num[4]<num[3] && num[4]<num[5] && num[4]<num[6] && num[4]<num[7] && num[4]<num[8] && num[4]<num[9]){
                Console.WriteLine("O menor número é: "+num[4]);
            }else if(num[5]< num[0] && num[5]< num[1] && num[5]<num[2] && num[5]<num[3] && num[5]<num[4] && num[5]<num[6] && num[5]<num[7] && num[5]<num[8] && num[5]<num[9]){
                 Console.WriteLine("O menor número é: "+num[5]);
            }else if(num[6]< num[0] && num[6]< num[1] && num[6]<num[2] && num[6]<num[3] && num[6]<num[4] && num[6]<num[5] && num[6]<num[7] && num[6]<num[8] && num[6]<num[9]){
                Console.WriteLine("O menor número é: "+num[6]);
            }else if(num[7]< num[0] && num[7]< num[1] && num[7]<num[2] && num[7]<num[3] && num[7]<num[4] && num[7]<num[5] && num[7]<num[6] && num[7]<num[8] && num[7]<num[9]){
                Console.WriteLine("O menor número é: "+num[7]);
            }else if(num[8]< num[0] && num[8]< num[1] && num[8]<num[2] && num[8]<num[3] && num[8]<num[4] && num[8]<num[5] && num[8]<num[6] && num[8]<num[7] && num[8]<num[9]){
                Console.WriteLine("O menor número é: "+num[8]);
        }
        if(num[0]> num[1] && num[0]> num[2] && num[0]>num[3] && num[0]>num[4] && num[0]>num[5] && num[0]>num[6] && num[0]>num[7] && num[0]>num[8] && num[0]>num[9]){
                Console.WriteLine("O maior número é: "+num[0]);
            }else if(num[1]> num[0] && num[1]<num[2] && num[1]>num[3] && num[1]>num[4] && num[1]>num[5] && num[1]>num[6] && num[1]>num[7] && num[1]>num[8] && num[1]>num[9]){
                  Console.WriteLine("O maior número é: "+num[1]);
            }else if(num[2]> num[0] && num[2]> num[1] && num[2]>num[3] && num[2]>num[4] && num[2]>num[5] && num[2]>num[6] && num[2]>num[7] && num[2]>num[8] && num[2]>num[9]){
                Console.WriteLine("O maior número é: "+num[2]);
            }else if(num[3]> num[0] && num[3]> num[1] && num[3]>num[2] && num[3]>num[4] && num[3]>num[5] && num[3]>num[6] && num[3]>num[7] && num[3]>num[8] && num[3]>num[9]){
                Console.WriteLine("O maior número é: "+num[3]);}
            else if(num[4]> num[0] && num[4]>num[1] && num[4]>num[2] && num[4]>num[3] && num[4]>num[5] && num[4]>num[6] && num[4]>num[7] && num[4]>num[8] && num[4]>num[9]){
                Console.WriteLine("O maior número é: "+num[4]);
            }else if(num[5]> num[0] && num[5]> num[1] && num[5]>num[2] && num[5]>num[3] && num[5]>num[4] && num[5]>num[6] && num[5]>num[7] && num[5]>num[8] && num[5]>num[9]){
                 Console.WriteLine("O maior  número é: "+num[5]);
            }else if(num[6]> num[0] && num[6]> num[1] && num[6]>num[2] && num[6]>num[3] && num[6]>num[4] && num[6]>num[5] && num[6]>num[7] && num[6]>num[8] && num[6]>num[9]){
                Console.WriteLine("O maior  número é: "+num[6]);
            }else if(num[7]> num[0] && num[7]> num[1] && num[7]>num[2] && num[7]>num[3] && num[7]>num[4] && num[7]>num[5] && num[7]>num[6] && num[7]>num[8] && num[7]>num[9]){
                Console.WriteLine("O maior  número é: "+num[7]);
            }else if(num[8]> num[0] && num[8]> num[1] && num[8]>num[2] && num[8]>num[3] && num[8]>num[4] && num[8]>num[5] && num[8]>num[6] && num[8]>num[7] && num[8]>num[9]){
                Console.WriteLine("O maior número é: "+num[8]);
        }


    }
}
}
