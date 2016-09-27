#include <string>
class Solution {
public:
    int myAtoi(string str) {
        long int answer = 0;
        int sign = 1;
        int chr= 0 ;

         if(str == "") //check empty string
        {
         answer = 0;
        }

        while(str[chr] == ' ') // skip white space
        {
            ++chr;
        }

        if (str[chr] =='-') // check the sign
        {
            sign = -1;
            chr++;
        }
        else if (str[chr] == '+')
        {
            chr++;
        }

        while(str[chr] >= '0' && str[chr] <='9') //find the number
        {
            answer = answer*10 +str[chr] - '0';

            if(answer*sign > INT_MAX)  // check for min and max values
            {
                return INT_MAX;
            }
            else if( answer*sign < INT_MIN)
            {
                return INT_MIN;
            }
            chr++;
        }

        return answer*sign;

    }
};
