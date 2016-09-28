#include <string>
class Solution {
public:
    bool isPalindrome(string s) {

        bool isPalin = false;

        int front = 0 ;
        int back = s.length()-1;


         if (s.length() <= 1) // check length
        {
            isPalin = true;
        }

        for(;front < back;front++,back--) // check palindrome
        {

            while(isalnum(s[front]) ==false && front <back) //Increment left pointer if not alphanumeric
            {
                front++;

            }

            while(isalnum(s[back]) ==false && front <back) //Increment right pointer if not alphanumeric
            {
                back--;

            }

            if(tolower(s[front]) != tolower(s[back])) // ignore uppercase
            {
                isPalin = false; // if false stop
                break;
            }
            else
            {
                isPalin = true;
            }
        }


        return isPalin;
    }
};
