internal class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Nhap mot so tu ban phim");
        int number = Convert.ToInt32(Console.ReadLine());
        if(number<2)
        {
            Console.WriteLine("Khong phai so nguyen to");

        }
        else
        {
            int i=2; 
            bool check=true;
            while (i<=Math.Sqrt(number))
            {
                if(number%i==0)
                {
                    check = false;
                break;
                }
                i++;
                
            }
            //diem bat dau 
            if (check)
                {
                    Console.WriteLine(number + " is a prime");
                }
                else
                {
                    Console.WriteLine(number + " is not a prime");
        }
    }
    }
}