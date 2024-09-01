#include <stdio.h>
#include <stdlib.h>
#include <string.h>
#include <ctype.h>


int mcd(int a,int b)
{
    int max = (a >= b) ? a : b;
    int min = (a < b) ? a : b;
    int r = max%min;
    if (r != 0){
        return mcd(min,r);
    }
    return min;
}

int main()
{

    printf("%d", mcd(43767, 5454));
    return 0;
}

