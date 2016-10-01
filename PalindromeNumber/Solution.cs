class Solution {
public:
    bool isPalindrome(int x) {

        if ( x < 0)
        {
          return false;
        }

        int temp = x;
        int result = 0;

        bool isPalin = false;



        while( temp > 0)
        {

            result = ( result *10 ) + temp %10;
            if(result > x)
            {
                return false;
            }
            temp = temp/10;
        }

        if (result == x)
        {
            isPalin = true;
        }
        else
        {
            isPalin = false;
        }



     return isPalin;


    }
};
