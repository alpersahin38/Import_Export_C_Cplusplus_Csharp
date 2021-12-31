#include "ce103-hw4-c-dll.h"

__declspec(dllexport) int ce103_fibonacciNumber(int fiIndex)
{
	fiIndex = fiIndex - 1;
	//First, let's define our integers.
	int f1 = 0, f2 = 1, n = 0;
	//This if statement implicitly checks "is not 0", so we reverse that to mean "is 0".

	int returnresult;
	if (fiIndex <= 0)
	{
		// if index is lower than 1 function will return 0
		return 0;
	}
	//I used "for" because there are repetitive processes here.
	for (int i = 1; i <= fiIndex; ++i)
	{
		f1 = f2;
		f2 = n;
		n = f1 + f2;
		returnresult = n;
		if (returnresult < 0)
		{
			//returresult or if the n is less than 0
			return -2;
		}
	}
	//fiIndex' th fibonacci number
	return returnresult;
}

__declspec(dllexport) char* ce103_strrev(char* fiStr)
{
	int i, j = ce103_strlen(fiStr) - 1, ch;
	//We are assigning the i and j variables.
	for (i = 0; i < j; i++, j--) {
		//Local variables are used in variables defined in functions.
		ch = fiStr[i];
		fiStr[i] = fiStr[j];
		fiStr[j] = ch;
	}
	//The return value of the reverse of the string you typed.
	return fiStr;
}

__declspec(dllexport) int ce103_strlen(const char* fiStr)
{
	//We assign an initial value to the count variable.
	//Null characters are used. The variable '\0' is the last term defined for the fiStr char.
	int number = 0;
	while (fiStr[number] != '\0')
		number++;
	return number;
}

__declspec(dllexport) char* ce103_strcat(char* fiDest, char* fiSrc)
{
	//We are assigning the a and j variables.

	int a = ce103_strlen(fiDest), j = 0;
	while (fiSrc[j] != '\0')
	{
		fiDest[a] = fiSrc[j];
		a++;
		j++;
	}
	//declaring the end of the string
	fiDest[a] = '\0';
	return fiDest;
}

__declspec(dllexport) int ce103_strcmp(const char* fiLhs, const char* fiRhs)
{
	int i;
	//if fiLhs[i] is equal to NULL, our return value is 0.
	//if our fiLhs[i] char is less than our fiRhs[i] char, our return value is -1 or 1.
	for (i = 0; fiLhs[i] == fiRhs[i]; i++) {
		if (fiLhs[i] == '\0')
			return 0;
	}
	if ((unsigned char)fiLhs[i] < (unsigned char)fiRhs[i])
		return -1;
	else
		return 1;
}

__declspec(dllexport) char* ce103_strcpy(char* foDestination, const char* fiSource)
{
	char* pointer = foDestination;
	char* a = fiSource;
	//Take a pointer pointing to the beginning of the destination string
	//The pointer we send to foDestination is equal to the pointer we send to fiSource.
	//This equality happens thanks to the code we wrote in the while loop.
	while (*a != '\0')
	{
		*pointer = *a;
		pointer++;
		a++;
	}
	*pointer = '\0';
	return foDestination;
}

__declspec(dllexport) void ce103_hex2bin(char* fiHex, int fiHexLen, unsigned char* foBin)
{
	//We are assigning the a and b variables.
	int a, b;
	for (;;) {
		a = *fiHex++; if (a == 0) break;
		if (a > 96) a -= 87;
		else if (a > 64) a -= 55;
		else a -= 48;
		b = *fiHex++; if (b == 0) { *foBin = a << 4; break; }
		if (b > 96) b -= 87;
		else if (b > 64) b -= 55;
		else b -= 48;
		*foBin++ = (a << 4) | b;
	}
	return fiHex;
}

__declspec(dllexport) void ce103_bin2hex(unsigned char* fiBin, int fiBinLen, char* foHex)
{
	//We are assigning the i , j (*k(pointers)) variables.
	int i, j, * k = fiBin + fiBinLen;
	while (fiBin < k) {
		i = *(fiBin++);
		j = i >> 4;
		*(foHex++) = j + (j > 9 ? 55 : 48);
		j = i & 15;
		*(foHex++) = j + (j > 9 ? 55 : 48);
	}
	*foHex = 0;

	return fiBin;
}
