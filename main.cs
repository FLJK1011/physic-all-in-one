using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace All_in_One
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Choose Your Program (1.Math , 2.Physic) : ");
                int program = int.Parse(Console.ReadLine());
                Console.WriteLine();

                while (true)
                {
                    //math
                    if (program == 1)
                    {
                        Console.Write("Select Your APP (1-2) or [0] for exit : ");
                        int math = int.Parse(Console.ReadLine());
                        Console.WriteLine();

                        if (math == 1)
                        {
                            Console.WriteLine("Quadratic Equations ");
                            Console.WriteLine();
                            Console.Write("Enter a (x2) : ");
                            double a = double.Parse(Console.ReadLine());
                            Console.WriteLine();
                            Console.Write("Enter b : ");
                            double b = double.Parse(Console.ReadLine());
                            Console.WriteLine();
                            Console.Write("Enter c : ");
                            double c = double.Parse(Console.ReadLine());
                            Console.WriteLine();

                            double delta = (((b * b)) - (4 * (a) * (c)));

                            if (delta < 0)
                            {
                                Console.WriteLine("This Equation Does Not Have Answer!");
                                Console.WriteLine("the reason : " + delta);
                                Console.WriteLine();
                            }
                            else
                            {
                                double x1 = ((-b + Math.Sqrt(delta)) / 2 * a);
                                double x2 = ((-b - Math.Sqrt(delta)) / 2 * a);

                                if (x1 == x2)
                                {
                                    Console.WriteLine("This Equation Have 1 Answer");
                                    Console.WriteLine();
                                    Console.WriteLine("Your x : " + x1);
                                    Console.WriteLine();
                                }
                                else
                                {
                                    Console.WriteLine("This Equation Have 2 Answer");
                                    Console.WriteLine();
                                    Console.WriteLine("Your x1 : " + x1);
                                    Console.WriteLine("Your x2 : " + x2);
                                    Console.WriteLine();
                                }

                            }
                        }
                        else if (math == 2)
                        {
                            Console.WriteLine("(ax+b)2");
                            Console.WriteLine();
                            Console.Write("Enter a : ");
                            sbyte a = sbyte.Parse(Console.ReadLine());
                            Console.WriteLine();
                            Console.Write("Enter x (Character): ");
                            string x = Console.ReadLine();
                            Console.WriteLine();
                            Console.Write("Enter b : ");
                            sbyte b = sbyte.Parse(Console.ReadLine());
                            Console.WriteLine();
                            double a_2 = (Math.Pow(a, 2));
                            double ab2 = (2 * a * b);
                            double b_2 = (Math.Pow(b, 2));
                            Console.WriteLine();

                            if (a == 1)
                            {
                                string z = "(" + x + "2 + " + b + ")2";
                                string z_1 = "x + " + ab2 + x + " + " + b_2;
                                Console.WriteLine(z);
                                Console.WriteLine();
                                Console.WriteLine(z_1);
                                Console.WriteLine();
                            }
                            else
                            {
                                string z = "(" + a + x + " + " + b + ")2";
                                string z_1 = a_2 + x + "2 + " + ab2 + x + " + " + b_2;
                                Console.WriteLine(z);
                                Console.WriteLine();
                                Console.WriteLine(z_1);
                                Console.WriteLine();
                            }
                        }
                        else if (math == 0)
                        {
                            break;
                        }
                        else if (math >= 3)
                        {
                            Console.WriteLine("Wrong Choice"); Console.WriteLine();
                        }
                    }


                    //physic
                    else if (program == 2)
                    {
                        while (true)
                        {
                            Console.Write("Select Your APP (1-16)  or [0] for exit : ");
                            int physic = int.Parse(Console.ReadLine());
                            Console.WriteLine();

                            if (physic == 1)
                            {
                                Console.WriteLine("Bordar Jabejaeei (2x) (m/s) ");
                                Console.WriteLine();
                                Console.Write("Enter x1 (m) : ");
                                int x1 = int.Parse(Console.ReadLine());
                                Console.WriteLine();
                                Console.Write("Enter t1 (s) : ");
                                int t1 = int.Parse(Console.ReadLine());
                                Console.WriteLine();
                                Console.Write("Enter x2 (m) : ");
                                int x2 = int.Parse(Console.ReadLine());
                                Console.WriteLine();
                                Console.Write("Enter t2 (s) : ");
                                int t2 = int.Parse(Console.ReadLine());
                                Console.WriteLine();

                                int delx;
                                int delt;
                                int v_;

                                delx = (x2 - x1);
                                if (x2 > x1)
                                {
                                    delx = (x2 + x1);
                                }
                                delt = (t2 - t1);
                                v_ = (delx / delt);

                                Console.Write("Delta x is : " + delx + "m");
                                Console.WriteLine();
                                Console.Write("Delta t is : " + delt + "s");
                                Console.WriteLine();
                                Console.Write("Average Speed (Sorate Motevaset) is : " + v_ + "m/s");
                                Console.WriteLine();
                                Console.WriteLine();
                            }
                            else if (physic == 2)
                            {
                                Console.WriteLine("Average Speed / Time Passed");
                                Console.WriteLine();
                                Console.Write("Enter Average Speed (Sorate Motevaset) : ");
                                int v__2 = int.Parse(Console.ReadLine());
                                Console.WriteLine();
                                Console.Write("Enter Time Passed : ");
                                int delt_2 = int.Parse(Console.ReadLine());
                                Console.WriteLine();
                                int delx_2 = (v__2 * delt_2);
                                Console.WriteLine("Passed Distance : " + delx_2);
                                Console.WriteLine();
                            }
                            else if (physic == 3)
                            {
                                Console.WriteLine("Average Speed / Distance Passed");
                                Console.WriteLine();
                                Console.Write("Enter Average Speed (Sorate Motevaset) : ");
                                int v__3 = int.Parse(Console.ReadLine());
                                Console.WriteLine();
                                Console.Write("Enter Distance Passed : ");
                                int delx_3 = int.Parse(Console.ReadLine());
                                Console.WriteLine();
                                int delt_3 = (v__3 / delx_3);
                                if (v__3 < delx_3)
                                {
                                    delt_3 = (delx_3 / v__3);
                                }
                                Console.WriteLine("Passed Times : " + delt_3);
                                Console.WriteLine();

                            }
                            else if (physic == 4)
                            {
                                Console.WriteLine("Times Passed / Distance Passed");
                                Console.WriteLine();
                                Console.Write("Enter Distance Passed : ");
                                int delx_4 = int.Parse(Console.ReadLine());
                                Console.WriteLine();
                                Console.Write("Enter Times Passed : ");
                                int delt_4 = int.Parse(Console.ReadLine());
                                Console.WriteLine();
                                int v__4 = (delx_4 / delt_4);
                                Console.WriteLine("Average Speed (Sorate Motevaset) : " + v__4);
                                Console.WriteLine();


                            }
                            else if (physic == 5)
                            {
                                Console.WriteLine("Convert m and s to km and h");
                                Console.WriteLine();
                                Console.Write("Enter m : ");
                                int m5 = int.Parse(Console.ReadLine());
                                Console.WriteLine();
                                Console.Write("Enter s : ");
                                int s5 = int.Parse(Console.ReadLine());
                                Console.WriteLine();
                                double km5 = ((float)m5 / 1000);
                                double h5 = ((float)s5 / 3600);
                                Console.WriteLine("m is : " + (float)km5 + "km");
                                Console.WriteLine("s is : " + (float)h5 + "h");
                                Console.WriteLine();
                            }
                            else if (physic == 6)
                            {
                                Console.WriteLine("Convert km and h to m and s");
                                Console.WriteLine();
                                Console.Write("Enter km : ");
                                int km_6 = int.Parse(Console.ReadLine());
                                Console.WriteLine();
                                Console.Write("Enter h : ");
                                int h_6 = int.Parse(Console.ReadLine());
                                Console.WriteLine();
                                double m_6 = ((float)km_6 * 1000);
                                double s_6 = ((float)h_6 * 3600);
                                Console.WriteLine("km is : " + (float)m_6 + "m");
                                Console.WriteLine("h is : " + (float)s_6 + "s");
                                Console.WriteLine();

                            }
                            else if (physic == 7)
                            {
                                Console.WriteLine("Convert m/s to km/h");
                                Console.WriteLine();
                                Console.Write("Enter m/s : ");
                                int m_s7 = int.Parse(Console.ReadLine());
                                Console.WriteLine();
                                int km_h7 = ((m_s7 * 3600) / 1000);
                                Console.WriteLine("Output is : " + km_h7 + "km/h");
                                Console.WriteLine();
                            }
                            else if (physic == 8)
                            {
                                Console.WriteLine("Convert km/h to m/s");
                                Console.WriteLine();
                                Console.Write("Enter km/h : ");
                                int km_h8 = int.Parse(Console.ReadLine());
                                Console.WriteLine();
                                int m_s8 = ((km_h8 * 1000) / 3600);
                                Console.WriteLine("Output is : " + m_s8 + "m/s");
                                Console.WriteLine();

                            }
                            else if (physic == 9)
                            {
                                Console.WriteLine("Instataneous Speed (Sorate Lahze-e)");
                                Console.WriteLine();
                                Console.Write("Enter x0 (m) : ");
                                int x0_9 = int.Parse(Console.ReadLine());
                                Console.WriteLine();
                                Console.Write("Enter v (m/s) : ");
                                int v_9 = int.Parse(Console.ReadLine());
                                Console.WriteLine();
                                Console.WriteLine("Moadele Makan-Zaman : x=" + v_9 + "t" + "+" + x0_9);
                                Console.WriteLine();
                                Console.Write("Enter t (s) : ");
                                int t_9 = int.Parse(Console.ReadLine());
                                Console.WriteLine();
                                int x1_9 = (v_9 * t_9 + x0_9);
                                Console.WriteLine("x1 is : " + x1_9 + "m");
                                Console.WriteLine();

                            }
                            else if (physic == 10)
                            {
                                Console.WriteLine("Average Acceleration (Shetabe Motevaset)");
                                Console.WriteLine();
                                Console.Write("Enter v0 : ");
                                int v0_10 = int.Parse(Console.ReadLine());
                                Console.WriteLine();
                                Console.Write("Enter Delta t : ");
                                int delt_10 = int.Parse(Console.ReadLine());
                                Console.WriteLine();
                                Console.Write("Enter v1 : ");
                                int v1_10 = int.Parse(Console.ReadLine());
                                Console.WriteLine();
                                int delv_10 = (v1_10 - v0_10);
                                int a__10 = (delv_10 / delt_10);
                                Console.WriteLine("Delta v is : " + delv_10 + "m/s");
                                Console.WriteLine();
                                Console.WriteLine("Average Acceleration : " + a__10 + " m/s2");
                                Console.WriteLine();

                            }
                            else if (physic == 11)
                            {
                                Console.WriteLine("Fixed acceleration (Shetab Saabet)");
                                Console.WriteLine();
                                Console.Write("Enter your v0 : ");
                                int v0_11 = int.Parse(Console.ReadLine());
                                Console.WriteLine();
                                Console.Write("Enter a (m/s2) : ");
                                int a_11 = int.Parse(Console.ReadLine());
                                Console.WriteLine();
                                Console.WriteLine("Moadele Sorat-Zaman is : " + "V=" + a_11 + "t+" + v0_11);
                                Console.WriteLine();
                                Console.Write("Enter t : ");
                                int t_11 = int.Parse(Console.ReadLine());
                                Console.WriteLine();
                                int v1_11 = (a_11 * t_11) + v0_11;
                                Console.WriteLine("v1 is  : " + v1_11);
                                Console.WriteLine();
                            }
                            else if (physic == 12)
                            {
                                Console.WriteLine("Mass in Other Planets");
                                Console.WriteLine();
                                Console.Write("Enter Mass (Vazn) (kg) : ");
                                int w_12 = int.Parse(Console.ReadLine());
                                int ww_12 = w_12 * 10;
                                Console.WriteLine();
                                while (true)
                                {
                                    Console.WriteLine("Choose Your Desired Planet in The Solar System\t " +
                                        "  for example :\n " +
                                        " \n" +
                                        " , 1.MERIKH\a\n , 2.ZOHAL\a\n , 3.MAH\a\n , 4.MOSHTARI\a\n , 5.ATAROD\a\n , 6.ZOHRE\a\n , 7.ORANOS\a\n , 8.NEPTON\a\n , 9.PLUTO\a\n , 10.SUN\a\n");

                                    Console.Write("Your Choice : ");
                                    int planet_12 = int.Parse(Console.ReadLine());
                                    Console.WriteLine();

                                    int merikh_12 = 4;
                                    int zohal_12 = 11;
                                    int mah_12 = 2;
                                    int moshtari_12 = 25;
                                    int atarod_12 = 4;
                                    int zohre_12 = 9;
                                    int oranos_12 = 9;
                                    int nepton_12 = 11;
                                    int pluto_12 = 1;
                                    int sun_12 = 270;

                                    //switch (planet_12)
                                    //{
                                    //    case 1:
                                    //        Console.WriteLine("Your Mass in Merikh is : " + (ww_12 / merikh_12) + "kg");
                                    //        break;
                                    //    case 2:
                                    //        Console.WriteLine("Your Mass in Zohal is : " + (ww_12 / zohal_12) + "kg");
                                    //        break;
                                    //    case 3:
                                    //        Console.WriteLine("Your Mass in Mah is : " + (ww_12 / mah_12) + "kg");
                                    //        break;
                                    //    case 4:
                                    //        Console.WriteLine("Your Mass in Moshtari is : " + (ww_12 / moshtari_12) + "kg");
                                    //        break;
                                    //    case 5:
                                    //        Console.WriteLine("Your Mass in Atarod is : " + (ww_12 / atarod_12) + "kg");
                                    //        break;
                                    //    case 6:
                                    //        Console.WriteLine("Your Mass in Zohre is : " + (ww_12 / zohre_12) + "kg");
                                    //        break;
                                    //    case 7:
                                    //        Console.WriteLine("Your Mass in Oranos is  : " + (ww_12 / oranos_12) + "kg");
                                    //        break;
                                    //    case 8:
                                    //        Console.WriteLine("Your Mass in Nepton is : " + (ww_12 / nepton_12) + "kg");
                                    //        break;
                                    //    case 9:
                                    //        Console.WriteLine("Your Mass in Pluto is : " + (ww_12 / pluto_12) + "kg");
                                    //        break;
                                    //    case 10:
                                    //        Console.WriteLine("Your Mass in Sun is :" + (ww_12 / sun_12) + "kg");
                                    //        break;
                                    //    default:
                                    //        Console.WriteLine("Wrong Choice");
                                    //        break;
                                    //}

                                    if (planet_12 == 1)
                                    {
                                        Console.WriteLine("Your Mass in Merikh is : " + (ww_12 / merikh_12) + "kg");
                                        Console.WriteLine();
                                        break;
                                    }
                                    else if (planet_12 == 2)
                                    {
                                        Console.WriteLine("Your Mass in Zohal is : " + (ww_12 / zohal_12) + "kg");
                                        Console.WriteLine();
                                        break;
                                    }
                                    else if (planet_12 == 3)
                                    {
                                        Console.WriteLine("Your Mass in Mah is : " + (ww_12 / mah_12) + "kg");
                                        Console.WriteLine();
                                        break;
                                    }
                                    else if (planet_12 == 4)
                                    {
                                        Console.WriteLine("Your Mass in Moshtari is : " + (ww_12 / moshtari_12) + "kg");
                                        Console.WriteLine();
                                        break;
                                    }
                                    else if (planet_12 == 5)
                                    {
                                        Console.WriteLine("Your Mass in Atarod is : " + (ww_12 / atarod_12) + "kg");
                                        Console.WriteLine();
                                        break;
                                    }
                                    else if (planet_12 == 6)
                                    {
                                        Console.WriteLine("Your Mass in Zohre is : " + (ww_12 / zohre_12) + "kg");
                                        Console.WriteLine();
                                        break;
                                    }
                                    else if (planet_12 == 7)
                                    {
                                        Console.WriteLine("Your Mass in Oranos is  : " + (ww_12 / oranos_12) + "kg");
                                        Console.WriteLine();
                                        break;
                                    }
                                    else if (planet_12 == 8)
                                    {
                                        Console.WriteLine("Your Mass in Nepton is : " + (ww_12 / nepton_12) + "kg");
                                        Console.WriteLine();
                                        break;
                                    }
                                    else if (planet_12 == 9)
                                    {
                                        Console.WriteLine("Your Mass in Pluto is : " + (ww_12 / pluto_12) + "kg");
                                        Console.WriteLine();
                                        break;
                                    }
                                    else if (pluto_12 == 10)
                                    {
                                        Console.WriteLine("Your Mass in Sun is :" + (ww_12 / sun_12) + "kg");
                                        Console.WriteLine();
                                        break;
                                    }
                                    else if (pluto_12 <= 11)
                                    {
                                        Console.WriteLine("Wrong Choice");
                                        Console.WriteLine();
                                    }
                                    Console.WriteLine();
                                }
                            }
                            else if (physic == 13)
                            {
                                Console.WriteLine("Covert m.g to N (Niroye Amodi Tekyegah)");
                                Console.WriteLine();
                                Console.Write("Enter m (kg) : ");
                                int m_13 = int.Parse(Console.ReadLine());
                                Console.WriteLine();
                                Console.Write("Enter g : ");
                                int g_13 = int.Parse(Console.ReadLine());
                                Console.WriteLine();
                                int N_13 = m_13 * g_13;
                                Console.WriteLine("N is : " + N_13 + "N");
                                Console.WriteLine();
                            }
                            else if (physic == 14)
                            {
                                Console.WriteLine("Static friction (Estekak Istaei)");
                                Console.WriteLine();
                                Console.Write("Enter m (kg) : ");
                                int m_14 = int.Parse(Console.ReadLine());
                                Console.WriteLine();
                                Console.Write("Enter g : ");
                                int g_14 = int.Parse(Console.ReadLine());
                                Console.WriteLine();
                                Console.Write("Enter Us (Zarib Estekak Istaei) : ");
                                float Us_14 = float.Parse(Console.ReadLine());
                                Console.WriteLine();
                                int N_14 = m_14 * g_14;
                                float fsmax_14 = N_14 * Us_14;
                                Console.WriteLine("Fsmax is : " + fsmax_14 + "N");
                                Console.WriteLine();
                            }
                            else if (physic == 15)
                            {
                                Console.WriteLine("Kinetic friction (Estekak Jonbeshi)");
                                Console.WriteLine();
                                Console.Write("Enter F (N) : ");
                                int F_15 = int.Parse(Console.ReadLine());
                                Console.WriteLine();
                                Console.Write("Enter m (kg) : ");
                                int m_15 = int.Parse(Console.ReadLine());
                                Console.WriteLine();
                                Console.Write("Enter g : ");
                                float g_15 = float.Parse(Console.ReadLine());
                                Console.WriteLine();
                                Console.Write("Enter Uk (Zarib Estekak Jonbeshi) : ");
                                float Uk_15 = float.Parse(Console.ReadLine());
                                Console.WriteLine();
                                float N_15 = (m_15 * g_15);
                                float fk_15 = (Uk_15 * N_15);
                                float a_15 = (F_15 - fk_15) / m_15;
                                Console.WriteLine("a is : " + a_15 + " m/s2");
                                Console.WriteLine();
                            }
                            else if (physic == 16)
                            {
                                Console.BackgroundColor = ConsoleColor.DarkBlue;
                                Console.Clear();
                                Console.WriteLine("Tempurator");
                                Console.WriteLine();

                                while (true)
                                {
                                    Console.WriteLine("1.Celcius to Farenhait");
                                    Console.WriteLine("2.Farenhait to Celcius");
                                    Console.WriteLine("3.Celcuis to Kelvin");
                                    Console.WriteLine("4.Kelvin to Celcius");
                                    Console.Write("Choose (1-4) and [0] for Exit : ");
                                    int temp = int.Parse(Console.ReadLine());
                                    Console.WriteLine();
                                    if (temp == 1)

                                    {
                                        Console.Write("Enter °C : ");
                                        byte celcius_1 = byte.Parse(Console.ReadLine());
                                        Console.WriteLine();
                                        double farenhait_1 = ((celcius_1 * 1.8) + 32);
                                        Console.WriteLine("Your °F is : " + farenhait_1);
                                        Console.WriteLine();
                                    }
                                    else if (temp == 2)
                                    {
                                        Console.Write("Enter °F : ");
                                        byte farenhait_2 = byte.Parse(Console.ReadLine());
                                        Console.WriteLine();
                                        double celcius_2 = ((farenhait_2 - 32) / 1.8);
                                        Console.WriteLine("Your °C is : " + celcius_2);
                                        Console.WriteLine();
                                    }
                                    else if (temp == 3)
                                    {
                                        Console.Write("Enter °C : ");
                                        int celcius_3 = int.Parse(Console.ReadLine());
                                        Console.WriteLine();
                                        double kelvin_3 = (celcius_3 + 273.15);
                                        Console.WriteLine("Your K is : " + kelvin_3);
                                        Console.WriteLine();
                                    }
                                    else if (temp == 4)
                                    {
                                        Console.Write("Enter K : ");
                                        int kelvin_4 = int.Parse(Console.ReadLine());
                                        Console.WriteLine();
                                        double celcius_4 = (kelvin_4 - 273.15);
                                        Console.WriteLine("Your °C is : " + celcius_4);
                                        Console.WriteLine();
                                    }
                                    else if (temp == 0)
                                    {
                                        Console.BackgroundColor = ConsoleColor.Black;
                                        Console.Clear();
                                        break;
                                    }
                                    else if (temp > 4)
                                    {
                                        Console.WriteLine("Wrong Choice");
                                        Console.WriteLine();
                                    }
                                }
                            }
                            else if (physic == 0)
                            {
                                break;
                            }

                            else
                            {
                                Console.WriteLine("Wrong Choice");
                                Console.WriteLine();
                            }
                        }
                    }
                    //Root Program
                    else if (program >= 3)
                    {
                        Console.WriteLine("Wrong Choice");
                        Console.WriteLine();
                        break;
                    }
                }
            }
        }
    }
}
