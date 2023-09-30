#include <iostream>
#include <cmath>

using namespace std;

int main() {
    while (true) {
        cout << "Choose Your Program (1.Math , 2.Physic) : ";
        int program;
        cin >> program;
        cout << endl;

        //math
        if (program == 1) {
            while (true) {
                cout << "Select Your APP (1-2) or [0] for exit : ";
                int math;
                cin >> math;
                if (math == 1)
                {
                    cout << "Quadratic Equations " << endl;
                    cout << endl;
                    cout << "Enter a (x2) : ";
                    double a_m1;
                    cin >> a_m1;
                    cout << endl;
                    cout << "Enter b : ";
                    double b_m1;
                    cin >> b_m1;
                    cout << endl;
                    cout << "Enter c : ";
                    double c_m1;
                    cin >> c_m1;
                    cout << endl;

                    double delta_m1 = (((b_m1 * b_m1)) - (4 * (a_m1) * (c_m1)));

                    if (delta_m1 < 0) {
                        cout << "This Equation Does Not Have Answer!" << endl;
                        cout << "the reason : " << delta_m1 << endl;
                        cout << endl;
                    }

                    else {
                        double x1_m1 = ((-b_m1 + sqrt(delta_m1)) / 2 * a_m1);
                        double x2_m1 = ((-b_m1 - sqrt(delta_m1)) / 2 * a_m1);

                        if (x1_m1 == x2_m1)
                        {
                            cout << "This Equation Have 1 Answer" << endl;
                            cout << endl;
                            cout << "Your x1 : " << x1_m1;
                            cout << endl;
                        }
                        else
                        {
                            cout << "This Equation Have 2 Answer " << endl;
                            cout << endl;
                            cout << "Your x1 : " << x1_m1 << endl;
                            cout << "Your x2 : " << x2_m1 << endl;
                            cout << endl;
                        }
                    }

                }
                else if (math == 2)
                {
                    cout << "App 2" << endl;
                }
                else if (math == 0)
                {
                    break;
                }
                else if (math >= 3)
                {
                    cout << "Wrong Number" << endl;
                }
            }
        } else if (program == 2) {
            while (true) {
                cout << "Select Your APP (1-16) or [0] for exit : ";
                int physic;
                cin >> physic;
                if (physic == 1)
                {
                    cout << "App 1" << endl;
                }
                else if (physic == 0) {
                    break;
                }
                else if (physic >= 17)
                {
                    cout << "Wrong Number" << endl;
                }
            }
        } else if (program == 0) {
            break;
        }
        else if (program >= 3)
        {
            cout << "Wrong Number" << endl;
        }
    }
    return 0;
}
