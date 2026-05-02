Console.WriteLine("\n Bizning GeometryGuru loyihamizga xush kelibsiz,\nBizni loyihamizda ikki amal ishlatish imkoni bor.\n1 Arifmetik  2 Geometrik. \n Amallardan birini tanleng: ");

//user bizga string kiritadi va biz uni 
string str = Console.ReadLine();
int userInput = Convert.ToInt32(str);

switch (userInput)
{
    // Arifmetik amal
    case 1:
        {
            Console.WriteLine(" \n Siz arifmetik amalni tanladingiz. \nAmal bajarish uchun kerakli sonlarni kiriting:");

            Console.WriteLine("\nBirinchi son: ");
            string str1 = Console.ReadLine();
            decimal userNum1 = Convert.ToDecimal(str1);

            Console.WriteLine("Ikkinchi son: ");  
            string str2 = Console.ReadLine();
            decimal userNum2 = Convert.ToDecimal(str2);

             Console.WriteLine("Operator (+, -, *, /): ");
            string oper = Console.ReadLine(); 

            if (oper == "+")
            {
                decimal result = userNum1 + userNum2;
                Console.WriteLine($" {userNum1} + {userNum2} = {result}");
            }
            else if (oper == "-")
            {
                decimal result = userNum1 - userNum2;
                Console.WriteLine($" {userNum1} - {userNum2} = {result}");
            }
            else if (oper == "*")
            {
                decimal result = userNum1 * userNum2;
                Console.WriteLine($" {userNum1} * {userNum2} = {result}");
            }
            else if (oper == "/")
            {   
                if(userNum2 == 0)
                {
                    Console.WriteLine("0 ga bulish mumkin emas");
                }
                else
                {
                    decimal result = userNum1 / userNum2;
                    Console.WriteLine($" {userNum1} / {userNum2} = {result}");   
                }
            }
            break;
        }

    // Geometrik amal
    case 2:
        {
            Console.WriteLine(" \n Siz Geometrik amalni tanladingiz. \nBizda bir nechta formalalar bor.\n\t 1.Kvadrat yuzasi  \n\t 2.Silindrni yuzasi \n\t 3. Kesik konus (Frustum) - To'liq sirt yuzasi, hajmi");
            string userChoice = Console.ReadLine();
            decimal userChoiceFormul = Convert.ToDecimal(userChoice);

            // Geometrik formulalar menyusi (nested switch)
            switch (userChoiceFormul)
            {
                //Kvadrat Yuzasi
                case 1:
                    {
                        Console.WriteLine("Kvadrat tomoni a ni kiriting : ");
                        string userA = Console.ReadLine();
                        decimal userKvadratA = Convert.ToDecimal(userA);

                        decimal square = userKvadratA * userKvadratA;
                        Console.WriteLine($" S = a * a = {userKvadratA} * {userKvadratA} = {square} "); 

                        break;
                    }

                    // Silindr hajmi
                    case 2:
                        Console.WriteLine("Silindrni hajmini topish uchun quydagilarni kiriting");

                        Console.WriteLine("Radius :");
                        string radius = Console.ReadLine();
                        double R = Convert.ToDouble(radius);

                        Console.WriteLine("Balandlik :");
                        string height = Console.ReadLine();
                        double h = Convert.ToDouble(height);

                        const double pi = 3.14;

                        double V = pi * Math.Pow(R,2) * h;
                        Console.WriteLine($"V = pi * R^2 * h = {V} ");
                    break;
                        
                    
                    case 3:
                        Console.WriteLine("Kesik konus (Frustum) - To'liq sirt yuzasi topish uchun quydagilarni kiriting");
                        
                        Console.WriteLine("Pastki asos radiusi (katta radius) R:");
                        string radiusR = Console.ReadLine();
                        double R_asos = Convert.ToDouble(radiusR);

                        Console.WriteLine("Yuqori asos radiusi (kichik radius) r:");
                        string radiusKichik = Console.ReadLine();
                        double r = Convert.ToDouble(radiusKichik);

                        Console.WriteLine("Kesik konus balandligi h:");
                        string heightKonus = Console.ReadLine();
                        double h_konus = Convert.ToDouble(heightKonus);


                        double S = Math.PI * (R_asos * R_asos + r * r + (R_asos + r) * Math.Sqrt((R_asos - r) * (R_asos - r) + h_konus * h_konus));
                        Console.WriteLine($"S = π[R² + r² + (R + r)√((R - r)² + h²)] = {S} ");

                    break;

                default :
                    Console.WriteLine("Bundan formula mavjud emas");
                break;
            }


            break;
        }
        
    // Foydalanuvchi faqat 1 yoki 2 ni kiritishi mumkin, boshqa qiymatlar uchun xatolik
    default:
        Console.WriteLine("Boshqa mavhud emas!!!");
        break;
}



