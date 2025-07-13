namespace Snox_US_Reservation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string IDNumber, name, gender, location, xr, xr1, travelType, sure1 = "n", place = "n", slct1, slct2, slct3, slct4, flightClass, promoCodeS; // String Veriables
            double ticketFee = 0, promoCode;                                                                                     // Double Veriables
            byte howManyPeopleByte;                                                                                              // Byte Veriables
            int howManyPeople, ebf = 125, izmir = 100, istanbul = 999, ankara = 999;                                             // Int Veriables
            long IDNumberLong;                                                                                                   // Long Veriables

            // Open page and jingle
        #region OPEN & IMAGE 

            Console.WriteLine("Welcome to the Snox'US Airlines Flight Ticket Reservation System"); // Opening Sentence
            System.Threading.Thread.Sleep(3000);                                                   // Waiting 
            Console.Write("Loading");                                                              // Loading Sentence
            System.Threading.Thread.Sleep(1000);
            Console.Write(".");
            System.Threading.Thread.Sleep(1000);
            Console.Write(".");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine(".");
            System.Threading.Thread.Sleep(1000);

            // Jingle
            #region MUSIC

            // Notes       (Do   Re   Mi   Fa   Sol  La   Si   Do)
            int[] notes = { 261, 293, 329, 349, 392, 440, 493, 523 };   // Notes & Array(Little)
            int duration1 = 500, duration = 200;                        //Note pause time

            // KVP Cendere
            Console.Beep(440, duration);   // La
            Console.Beep(440, duration);   // La
            Console.Beep(440, duration);   // La
            Console.Beep(493, duration);   // Si
            Console.Beep(493, duration);   // Si
            Console.Beep(493, duration);   // Si
            Console.Beep(523, duration);   // Do
            Console.Beep(523, duration);   // Do
            Console.Beep(523, duration);   // Do
            Console.Beep(493, duration);   // Si
            Console.Beep(493, duration);   // Si
            Console.Beep(493, duration);   // Si
            Console.Beep(440, duration);   // La
            Console.Beep(440, duration);   // La
            Console.Beep(440, duration);   // La
            Console.Beep(493, duration);   // Si
            Console.Beep(493, duration);   // Si
            Console.Beep(493, duration);   // Si
            Console.Beep(392, duration);   // Sol
            Console.Beep(392, duration);   // Sol
            Console.Beep(392, duration);   // Sol
            Console.Beep(440, duration1);  // La

        #endregion

        return0:

            // Opening Image
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@%@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@");
            System.Threading.Thread.Sleep(100);
            Console.WriteLine("@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@%@@@@@@@@@@@@@%#**%@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@");
            System.Threading.Thread.Sleep(100);
            Console.WriteLine("@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@#*%@@@@@@@@@%#**++*@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@");
            System.Threading.Thread.Sleep(100);
            Console.WriteLine("@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@#+**@@@@@@%#*******%@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@");
            System.Threading.Thread.Sleep(100);
            Console.WriteLine("@@@@@@@@@@@@@@@@@@@@@@@@@@@@@#+**+#@%#**+********@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@");
            System.Threading.Thread.Sleep(100);
            Console.WriteLine("@@@@@@@@@@@@@@@@@@@@@@@@@@@@#+*******+**********%@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@");
            System.Threading.Thread.Sleep(100);
            Console.WriteLine("@@@@@@@@@@@@@@@@@@@@@@@@@@@%********************@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@");
            System.Threading.Thread.Sleep(100);
            Console.WriteLine("@@@@@@@@@@@@@@@@@@@@@@@@@@%*********************%@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@");
            System.Threading.Thread.Sleep(100);
            Console.WriteLine("@@@@@@@@@@@@@@@@@@@@@@@@@@***********************#@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@");
            System.Threading.Thread.Sleep(100);
            Console.WriteLine("@@@@@@@@@@@@@@@@@@@@@@@@@#+***********************#@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@");
            System.Threading.Thread.Sleep(100);
            Console.WriteLine("@@@@@@@@@@@@@@@@@@@@@@@@#**************************#@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@");
            System.Threading.Thread.Sleep(100);
            Console.WriteLine("@@@@@@@@@@@@@@@@@@@@@@#*****************************%@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@");
            System.Threading.Thread.Sleep(100);
            Console.WriteLine("@@@@@@@@@@@@@@@@@@@@%*+*************************#%***%@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@");
            System.Threading.Thread.Sleep(100);
            Console.WriteLine("@@@@@@@@@@@@@@@@@@@*+****************************###**#%@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@");
            System.Threading.Thread.Sleep(100);
            Console.WriteLine("@@@@@@@@@@@@@@@@@%***************************************%@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@");
            System.Threading.Thread.Sleep(100);
            Console.WriteLine("@@@@@@@@@@@@@@@@#******************************************#%@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@");
            System.Threading.Thread.Sleep(100);
            Console.WriteLine("@@@@@@@@@@@@@@@#+*********************************************#@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@");
            System.Threading.Thread.Sleep(100);
            Console.WriteLine("@@@@@@@@@@@@@@#+********************************************+*%@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@");
            System.Threading.Thread.Sleep(100);
            Console.WriteLine("@@@@@@@@@@@@@#+*****************************++*************#%@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@");
            System.Threading.Thread.Sleep(100);
            Console.WriteLine("@@@@@@@@@@@@%***********************%%******#%%@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@");
            System.Threading.Thread.Sleep(100);
            Console.WriteLine("@@@@@@@@@@@@***********************#@@**#%@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@");
            System.Threading.Thread.Sleep(100);
            Console.WriteLine("@@@@@@@@@@@%***********************%@@#%@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@");
            System.Threading.Thread.Sleep(100);
            Console.WriteLine("@@@@@@@@@@@#***********************#@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@");
            System.Threading.Thread.Sleep(100);
            Console.WriteLine("@@@@@@@@@@@*************************%@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@");
            System.Threading.Thread.Sleep(100);
            Console.WriteLine("@@@@@@@@@@@**************************%@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@");
            System.Threading.Thread.Sleep(100);
            Console.WriteLine("@@@@@@@@@@@***************************#@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@");
            System.Threading.Thread.Sleep(100);
            Console.WriteLine("@@@@@@@@@@@*****************************#@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@");
            System.Threading.Thread.Sleep(100);
            Console.WriteLine("@@@@@@@@@@@********************************%@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@");
            System.Threading.Thread.Sleep(100);
            Console.WriteLine("@@@@@@@@@@@********************************+**#%@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@");
            System.Threading.Thread.Sleep(100);
            Console.WriteLine("@@@@@@@@@@@#+***#*****************************+**##%@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@");
            System.Threading.Thread.Sleep(100);
            Console.WriteLine("@@@@@@@@@@@@***#@#+*******************************+***#%%@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@");
            System.Threading.Thread.Sleep(100);
            Console.WriteLine("@@@@@@@@@@@@#+*@@@*************************************+***#%@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@");
            System.Threading.Thread.Sleep(100);
            Console.WriteLine("@@@@@@@@@@@@@**@@@@****************************************+**#%@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@");
            System.Threading.Thread.Sleep(100);
            Console.WriteLine("@@@@@@@@@@@@@%*@@@@%*********************************************#%@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@");
            System.Threading.Thread.Sleep(100);
            Console.WriteLine("@@@@@@@@@@@@@@@@@@@@%***********************************************#@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@");
            System.Threading.Thread.Sleep(100);
            Console.WriteLine("@@@@@@@@@@@@@@@@@@@@@%**********************************************+*#@@@@@@@@@@@@@@@@@@@@@@@@@@@@@");
            System.Threading.Thread.Sleep(100);
            Console.WriteLine("@@@@@@@@@@@@@@@@@@@@@@@*+*******************************************#***#@@@@@@@@@@@@@@@@@@@@@@@@@@@");
            System.Threading.Thread.Sleep(100);
            Console.WriteLine("@@@@@@@@@@@@@@@@@@@@@@@@#*********************************************##**#@@@@@@@@@@@@@@@@@@@@@@@@@");
            System.Threading.Thread.Sleep(100);
            Console.WriteLine("@@@@@@@@@@@@@@@@@@@@@@@@@%*+********************************************%%**%@@@@@@@@@@@@@@@@@@@@@@@");
            System.Threading.Thread.Sleep(100);
            Console.WriteLine("@@@@@@@@@@@@@@@@@@@@@@@@@@@#********%#***+*******************************#@%##@@@@@@@@@@@@@@@@@@@@@@");
            System.Threading.Thread.Sleep(100);
            Console.WriteLine("@@@@@@@@@@@@@@@@@@@@@@@@@@@@@#*+****#@@@%#****+****************************%@%#@@@@@@@@@@@@@@@@@@@@@");
            System.Threading.Thread.Sleep(100);
            Console.WriteLine("@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@#*+***#@@@@@@@%##****++**********************#@@@@@@@@@@@@@@@@@@@@@@@");
            System.Threading.Thread.Sleep(100);
            Console.WriteLine("@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@#**++*%@@@@@@@@@@@%%###****+***************+*@@@@@@@@@@@@@@@@@@@@@@");
            System.Threading.Thread.Sleep(100);
            Console.WriteLine("@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@%#**+#@@@@@@@@@@@@@@@@@@%%#***+*************@@@@@@@@@@@@@@@@@@@@@");
            System.Threading.Thread.Sleep(100);
            Console.WriteLine("@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@%#**%@@@@@@@@@@@@@@@@@@@@@%%#**+**********@@@@@@@@@@@@@@@@@@@@");
            System.Threading.Thread.Sleep(100);
            Console.WriteLine("@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@%@@@@@@@@@@@@@@@@@@@@@@@@@@%#**+******#@@@@@@@@@@@@@@@@@@@");
            System.Threading.Thread.Sleep(100);
            Console.WriteLine("@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@%#******+#@@@@@@@@@@@@@@@@@@");
            System.Threading.Thread.Sleep(100);
            Console.WriteLine("@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@%#*+***@@@@@@@@@@@@@@@@@@");
            System.Threading.Thread.Sleep(100);
            Console.WriteLine("@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@#**+#@@@@@@@@@@@@@@@@@");
            System.Threading.Thread.Sleep(100);
            Console.WriteLine("@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@#**@@@@@@@@@@@@@@@@@");
            System.Threading.Thread.Sleep(100);
            Console.WriteLine("@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@%*#@@@@@@@@@@@@@@@@");
            System.Threading.Thread.Sleep(100);
            Console.WriteLine("@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@%#@@@@@@@@@@@@@@@@");
            System.Threading.Thread.Sleep(100);
            Console.WriteLine("@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@");
            System.Threading.Thread.Sleep(100);

            Console.ResetColor();               // Reset Color 

            #endregion

            // The beginning and learning gender and name
        #region Start Gender & Name

            Console.WriteLine("Are you Turkish citizen" + "\nYes, Press [y]" + "\nNo. Press []");
            slct4 = Console.ReadLine();
            if (slct4 == "y")
            {
                Console.WriteLine("Please enter Turkish ID number");
                IDNumberLong = long.Parse(Console.ReadLine());

            }
            else
            {
                Console.WriteLine("Please enter passport number");
                IDNumber = Console.ReadLine();
            }

            Console.WriteLine("What is Your Gender" + "\n[men],[women] or [other]"); //Learn Gender
            gender = Console.ReadLine();

            if (gender == "men")
            {
                gender = "Mr.";
                Console.ForegroundColor = ConsoleColor.Blue;
            }
            else if (gender == "women")
            {
                gender = "Mrs.";
                Console.ForegroundColor = ConsoleColor.Red;
            }

            Console.WriteLine("What is Your Surname"); //Learn Name
            name = Console.ReadLine();

            Console.WriteLine("Welcome, " + gender + " " + name); //A person can define herself/himself as orange juice if he/she wants
            Console.ResetColor();
            System.Threading.Thread.Sleep(2000);                 // Waiting 2 seconds

        #endregion

        // Learning where to go
        #region Place to Go

        return1:
            Console.WriteLine("Where will you go?");               // Asking where to go
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("İZMİR = Press [35]");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("İSTANBUL = Press [785336384534]");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("ANKARA = Press [785336384506]");
            location = Console.ReadLine();

            if (location == "35")
            {
                Console.WriteLine("You have selected İzmir");               //When the user selects İzmir
                Console.WriteLine("Ticket Fee is = " + izmir +"$");         // Ticket Fee for İzmir
                ticketFee = izmir;                                          // Ticket Fee veriable for İzmir
                place = "İzmir";                                            // Place variable for İzmir
            }
            else if (location == "785336384534")
            {
                Console.WriteLine("You have selected İstanbul");            // When the user selects İstanbul
                Console.WriteLine("Ticket Fee is = " + istanbul + "999$");  // Ticket Fee for İstanbul
                ticketFee = istanbul;                                       // Ticket Fee veriable for İstanbul
                place = "İstanbul";                                         // Place variable for İstanbul
            }
            else if (location == "785336384506")
            {
                Console.WriteLine("You have selected Ankara");               // When the user selects Ankara
                Console.WriteLine("Ticket Fee is = " + ankara + "$");        // Ticket Fee for Ankara
                ticketFee = ankara;                                          // Ticket Fee veriable for Ankara
                place = "Ankara";                                            // Place variable for Ankara
            }
            else
            {
                Console.WriteLine("Invalid choice." + "\nTry again, Press [r]" + "\nExit, Press []"); // Return or Exit Code
                xr = Console.ReadLine();
                if (xr == "r")
                {
                    goto return1;
                }
                else
                {
                    Console.WriteLine("Sure?" + "\nYes, Press [y]" + "\nNo, Press []");                // Are you sure want to exit page
                    sure1 = Console.ReadLine();
                }
                if (sure1 == "y")
                {
                    Console.WriteLine("Thank you for using the Snox'US Airlines Flight Ticket Reservation System"); // Exit page
                    Console.Write("Exiting");
                    System.Threading.Thread.Sleep(1000);
                    Console.Write(".");
                    System.Threading.Thread.Sleep(1000);
                    Console.Write(".");
                    System.Threading.Thread.Sleep(1000);
                    Console.Write(".");
                    Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("You are redirected back to selection page");                    // Return to selection page
                    System.Threading.Thread.Sleep(2000);
                    goto return1;
                }
            }

        #endregion

        // Learning travel type
        #region Round-Trip & Departures

        return2:
            Console.WriteLine("Travel type for " + place + "\nRound-Trip, Press [r]" + "\nDepartures, Press [d]");
            travelType = Console.ReadLine();
            if (travelType == "r")
            {
                Console.WriteLine("Congratulations, you won a 50% discount (Only for return)");
                ticketFee *= 1.5;
                travelType = "Round-Trip";
            }
            else if (travelType == "d")
            {
                Console.WriteLine("There is a 50% discount on Round-Trips (Only for return)" + "\nDo you want to change your selection" + "Yes, Press [y]" + "No, Press []");
                slct1 = Console.ReadLine();
                travelType = "Departures";
                if (slct1 == "y")
                {
                    goto return2;
                }
            }


        #endregion

        // Learning flight class
        #region Flight Class

        return3:
            Console.WriteLine("Please selected Flight Class" + "\nEconomy Class, Press [e]" + "\nBusiness Class, Press [b]" + "\nFirst Class, Press [f]");
            flightClass = Console.ReadLine();

            if (flightClass == "b")
            {
                Console.WriteLine("You have selected Business Class");
                ticketFee += (ebf * 2);
                flightClass = "Business Class";
                if (travelType == "Round-Trip")
                {
                    ticketFee += ebf;
                }
            }
            else if (flightClass == "f")
            {
                Console.WriteLine("You have selected First Class");
                ticketFee += (ebf * 4);
                flightClass = "First Class";
                if (travelType == "Round-Trip")
                {
                    ticketFee += (ebf * 2);
                }
            }
            else if (flightClass == "e")
            {
                Console.WriteLine("You have selected Economy Class");
                flightClass = "Economy Class";
            }
            else
            {
                Console.WriteLine("Invalid choice." + "\nTry again, Press [r]" + "\nExit, Press []");
                xr = Console.ReadLine();
                if (xr == "r")
                {
                    goto return3;
                }
                else
                {
                    Console.WriteLine("Sure?" + "\nYes, Press [y]" + "\nNo, Press []");
                    sure1 = Console.ReadLine();
                }
                if (sure1 == "y")
                {
                    Console.WriteLine("Thank you for using the Snox'US Airlines Flight Ticket Reservation System");
                    Console.Write("Exiting");
                    System.Threading.Thread.Sleep(1000);
                    Console.Write(".");
                    System.Threading.Thread.Sleep(1000);
                    Console.Write(".");
                    System.Threading.Thread.Sleep(1000);
                    Console.Write(".");
                    Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("You are redirected back to selection page");
                    System.Threading.Thread.Sleep(2000);
                    goto return3;
                }
            }
        #endregion

        // Learning how many people will travel
        #region How Many People 

        return4:
            Console.WriteLine("How many people will be traveling?");
            howManyPeople = int.Parse(Console.ReadLine());
            //howManyPeople = Convert.ToInt32(howManyPeople);
            if (howManyPeople <= 4)
            {
                Console.WriteLine("%25 discount for 5 people or more" + "\nDo you want to change your selection" + "\nYes, Press [y]" + "\nNo, Press []");
                slct1 = Console.ReadLine();
                if (slct1 == "y")
                {
                    goto return4;
                }
            }
            else if (howManyPeople > 50)
            {
                Console.WriteLine("Our Plane has a capacity of 50 people");
                Console.WriteLine("Your are directed to the selection page");
                System.Threading.Thread.Sleep(3000);
                goto return4;
            }
            checked 
            {
                howManyPeopleByte = (byte)howManyPeople;
            }
                ticketFee *= howManyPeople;

            Console.WriteLine("Total Ticket Fee= " + ticketFee);

            #endregion

        // Promo Code
        #region Promo Code

            Console.WriteLine("Do you have a promo code" + "\nYes, Press [y]" + "\nNo, Press []");
            promoCodeS = Console.ReadLine();
            if (promoCodeS == "y")
            {
            return5:
                Console.WriteLine("Please enter your promo code");
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("3");
                Console.ResetColor();
                promoCode = Convert.ToDouble(Console.ReadLine());

                if (promoCode == 22 / 7)
                {
                    Console.WriteLine("Congratulations, you won a 15% discont.");
                    ticketFee *= 0.85;
                    Console.WriteLine("New Ticket Fee = " + ticketFee + "$");
                }
                else
                {
                    Console.WriteLine("Invalid promo code" + "\nWould you like to try again?" + "\nYes, Press [y]" + "\nNo, Press []");
                    slct3 = Console.ReadLine();
                    if (slct3 == "y")
                    {
                        Console.WriteLine("You are redirected back to the promo code page");
                        System.Threading.Thread.Sleep(2000);
                        goto return5;
                    }

                }
            }

            #endregion

        // Close Page
        #region Close

            Console.WriteLine("The place you selected to go: " + place);
            Console.WriteLine("If the selecion is incoorect, Press [r] to return");
            xr = Console.ReadLine();
            if (xr == "r")
            {
                Console.WriteLine("You are redirected back to selection page");
                System.Threading.Thread.Sleep(2000);
                goto return1;
            }

            Console.WriteLine("Your Selected Travel Type: " + travelType);
            Console.WriteLine("If the selecion is incoorect, Press [r] to return");
            xr = Console.ReadLine();
            if (xr == "r")
            {
                Console.WriteLine("You are redirected back to selection page");
                System.Threading.Thread.Sleep(2000);
                goto return2;
            }

            Console.WriteLine("Your Selected Flight Ckass: " + flightClass);
            Console.WriteLine("If the selecion is incoorect, Press [r] to return");
            xr = Console.ReadLine();
            if (xr == "r")
            {
                Console.WriteLine("You are redirected back to selection page");
                System.Threading.Thread.Sleep(2000);
                goto return3;
            }

            Console.WriteLine("The number of people you selected: " + howManyPeople);
            Console.WriteLine("If the selecion is incoorect, Press [r] to return");
            xr = Console.ReadLine();
            if (xr == "r")
            {
                Console.WriteLine("You are redirected back to selection page");
                System.Threading.Thread.Sleep(2000);
                goto return4;
            }

            Console.WriteLine("Your Payment= " + ticketFee + "$");
            System.Threading.Thread.Sleep(3000);

            Console.WriteLine("Would you like to return the main menu?" + "\nYes, Press [y]" + "\nNo, Press []");
            slct2 = Console.ReadLine();
            if (slct2 == "y")
            {
                Console.WriteLine("Your return to the main menu");
                System.Threading.Thread.Sleep(3000);
                Console.Write(".");
                System.Threading.Thread.Sleep(1000);
                Console.Write(".");
                System.Threading.Thread.Sleep(1000);
                Console.Write(".");
                goto return0;
            }

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Thank You For Selected 'US" + "\nNot you, Always 'US" + "\nSnox'US AirLines");
            Console.ResetColor();
            Console.Write("Exiting");
            System.Threading.Thread.Sleep(3000);
            Console.Write(".");
            System.Threading.Thread.Sleep(1000);
            Console.Write(".");
            System.Threading.Thread.Sleep(1000);
            Console.Write(".");
            Environment.Exit(0);


            #endregion



/* 
 
Açılış cümlesi ile başlıyoruz. Hemen sonrasında bir yükleme ekranından ve onun bitiminde  cıngılımızı çalıyor çıktı rengimizi değiştiriyor ve sleep komutu ile tek tek şirket logosunu yazdırıyoruz ve rengimizi eski haline çevirerek ilk bloğumuzu bitiriyoruz.

Öncelikle kullanıcıya Türk olup olmadığını soruyoruz eğer Türk ise TC numarasını isteyip değişkene atıyoruz değilse de pasaport numarasını isteyip değişkene atıyoruz ama bunu sebepsiz yere string olarak değil de long olarak saklıyoruz çünkü neden olmasın devamında kullanıcıdan cinsiyetini sorup öğreniyoruz (açık uçlu bir seçimde var eğer kullanıcı buradan kendini istediği gibi tanımlayabiliyor isterse portakal suyu bile olabilir). Seçimine göre cinsiyet tanımıyla soyadını ekrana yazdırarak hoş geldiniz diyoruz ve erkek ya da kadınsa ona göre bir renklendirme yapılıyor. Daha sonrasında ise çıktı rengimizi tekrar sıfırlıyoruz.

Kullanıcıdan gitmek istediği yeri öğreniyoruz (Şirketimiz henüz sadece 3 yere sefer düzenlediği için kullanıcıdan bu yerler arasında seçim yapmasını istiyoruz). Gideceği yere göre bilet ücretini tanımlıyoruz bilet miktarını bir değişkende tutuyoruz ki fiyatlara kolayca bir güncelleme yapılabilsin. Eğer geçerli bir seçim yapmamışsa "Seçimi tekrarlamak" mı? yoksa "çıkış yapmak" mı? istediğini soruyoruz.
Tekrarlamak isterse seçim sayfasına geri gönderiyoruz.
Çıkış yapmak istemişse bundan emin olup olmadığını (Yanlışlıkla tıklamış olabileceği için) soruyoruz. Eminse teşekkür edip bir çıkış ekranı ile programı sonlandırıyoruz değilse tekrar seçim ekranına yönlendiriyoruz.(Çıkış ve tekrar geri dönmek isterken kısa beklemelerimiz var)

Kullanıcıya seyahat tipini soruyoruz. Kullanıcı gidiş dönüş seçerse ona %50'lik bir indirim tanıyoruz (sadece dönüş için).
Eğer tek gidiş seçerse ona Gidiş dönüş aldığı takdirde %50 indirim tanımlayabileceğimizi söylüyoruz ve seçimi tekrarlamak isteyip istemeyeceğini soruyoruz kabul ederse seçim sayfasına geri döndürüyor etmezse sonraki işleme geçiyoruz.(Eğer gidiş dönüş alırsa indirimli olacağından bilet parası * 1,5 ile bilet parası içine tekrar atıyoruz)

Kullanıcıya uçuş sınıfını seçeneklerden seçtiriyoruz.
Ekonomi seçerse bir işlemimiz yok
Business seçerse bilet parsını 250 arttırıyoruz
First Class seçerse bilet parasını 500 arttırıyoruz
Gidiş-Dönüş ve Business seçerse 250 üstüne sonradan 125 daha ekliyoruz
Gidiş-Dönüş ve First Class seçerse 500 üstüne 250 ekliyoruz
Artış miktarını da bir değişkende tutuyoruz ki uçuş sınıfı fiyatları değişirse güncellemesi kolay olsun
Eğer geçerli bir seçim yapmamışsa "Seçimi tekrarlamak" mı? yoksa "çıkış yapmak" mı? istediğini soruyoruz.
Tekrarlamak isterse seçim sayfasına geri gönderiyoruz.
Çıkış yapmak istemişse bundan emin olup olmadığını (Yanlışlıkla tıklamış olabileceği için) soruyoruz. Eminse teşekkür edip bir çıkış ekranı ile programı sonlandırıyoruz değilse tekrar seçim ekranına yönlendiriyoruz.(Çıkış ve tekrar geri dönmek isterken kısa beklemelerimiz var)

Kullanıcıdan kaç kişi seyahat edeceğini istiyoruz. 4 kişi veya daha az kişi seçilmişse 5 kişide %25'lik bir indirim olduğunu seçimi tekrarlamak isteyip istemeyeceğini soruyoruz isterse seçim sayfasına geri gönderiyoruz istemezse devam ediyor. Ve eğer kişi sayısı 50'den büyükse uçak kapasitesi aşılacağından biraz bekleme ile seçim sayfasına geri gönderiliyor. Son işlemle beraber uçak kapasitesi max 50 olacağından bu değerleri int yerine byte'ta tutmayı tercih ediyor ve checked kullanarak (kullanma amacımız eğer sayı byte değerinin veri kaybı olması halinde hata vermesi(ki bu imkansız)) byte çeviriyoruz. Sonrasında da bilet fiyatımız ve kişi sayısını çarparak bilet fiyatımızı güncelliyoruz.

Kullanıcıya bir promosyon kodu olup olmadığını soruyoruz eğer varsa ondan promosyon kodunu istiyoruz ve promosyon kodu doğruysa %15'lik bir indirim sağlıyoruz, yanlışsa tekrar denemek isteyip istemeyeceğini soruyoruz denemek istersen promosyon kodunu girdiği sayfaya yönlendiriyor istemezse devam ediyoruz.

Kapanış ekranında ise tüm bilgileri tekrar kontrol ettiriyoruz eğer hatalı bir yer varsa o sayfaya geri yönlendiriyoruz yoksa kullanıcıya toplam bilet ücretini yazdırarak, ana menüye dönmek isteyip istemeyeceğini soruyoruz isterse en başa geri döndürüyoruz(Kısa bir beklemeyle beraber). İstemezse bir kapanış yazısıyla programı sonlandırıyoruz

 */
        }
    }
}
