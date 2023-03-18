#region Task 1
//int toplam = 0;

//for (int i = 1; i <= 1000; i++)
//{
//    toplam += i;
//}
//if (toplam % 7 == 0)
//{
//    Console.WriteLine("ededlerin cemi 7 ye bolunur");
//}
//else
//{
//    Console.WriteLine("bolunmur");
//}
/*
 1) 1-1000 qeder ededlerin cemi 7 bolunurmu?

 */
#endregion
#region Task 2
//List<int> numbers = new List<int>();

//for (int i = 1; i <= 1000; i++)
//{
//    if (i % 7 == 0 && i % 8 == 0)
//    {
//        numbers.Add(i);
//    }
//}

//foreach (int num in numbers)
//{
//    Console.WriteLine(num);
//}




/*
 2) 1-1000 qeder ededlerin icerisinde hem 7-e, hemde 8-e bolunenlerin siyahisi

 */
#endregion
#region Task 2 (v2)
//for (int i = 1; i <= 1000; i++)
//{
//    if (i % 7 == 0 && i % 8 == 0)
//    {
//        Console.WriteLine(i);
//    }
//}
/*
 2) 1-1000 qeder ededlerin icerisinde hem 7-e, hemde 8-e bolunenlerin siyahisi

 */
#endregion
#region Task 3
//for (int i = 1; i <= 1000; i++)
//{
//    int num=i;
//    int sum2 = 0;   
//    while (num > 0)
//    {
//       int sum = num % 10;
//        num /= 10;
//        sum2 += sum;
//    }
//    if (sum2 % 3 == 0)
//    {
//        Console.WriteLine(i);
//    }
//}
/*
 3) 1-1000 qeder ederlerin icerisinden  ele ededleri cap et ki, reqemleri cemi 3-e bolunsun
 */
#endregion
#region Task 4
//for (int i = 1; i <= 1000; i++)
//{
//    int num = i;
//    int sum2 = 0;
//    if (i % 10 != 3)
//    {

//        while (num > 0)
//        {
//            int sum = num % 10;
//            num /= 10;
//            sum2 += sum;
//        }
//        if (sum2 % 3 == 0)
//        {
//            Console.WriteLine(i);
//        }
//    }
//}
/*
 4) 1-1000 qeder ederlerin icerisinden ele ededleri cap etki
    reqemleri cemi 3 e bolunsun ve sonuncu reqem 3 olmasin.
 */
#endregion
#region Task 5
//for (int i = 1; i <= 1000; i++)
//{
//    int num = i;
//    int sum2 = 0;
//    if (i % 5 == 0)
//    {
//        while (num > 0)
//        {
//            int sum = num % 10;
//            num /= 10;
//            sum2 += sum;
//        }
//        if (sum2 % 5 == 0)
//        {
//            Console.WriteLine(i);
//        }
//    }
//}

/*
 5)  1-1000 qeder ederlerin icerisinden  ele ededleri cap etki :
    hem reqemleri cemi 5-e bolunsun,
    hem de ozu 5-e bolunsun
 */
#endregion
#region Task 6
//int i, sum, secondNumber;
//for (i = 1; i <= 1000; i++)
//{
//    if (i % 2 == 0)
//    {
//        int lastRemaider = 0;
//        secondNumber = i;
//        while (secondNumber > 0)
//        {
//            int remaninder = secondNumber % 10;
//            secondNumber /= 10;
//            lastRemaider = remaninder;
//        }
//        if (lastRemaider % 2 == 1)
//        {
//            int newNumber = i;
//            sum = 0;
//            while (newNumber>0)
//            {
//                int remainder = newNumber % 10;
//                newNumber/= 10;

//                sum += remainder;
//            }
//            if (sum%2==1)
//            {
//                Console.WriteLine(i);
//            }


//        }
//    }
//}
/*
 6)  1-1000 qeder ederlerin icerisinden  ele ededleri cap etki :
    hem ozu cut eded olsun,
    hem reqemleri cemi tek eded olsun,
    hem I reqemi tek eded olsun
 */
#endregion
#region Task 7
//int i;
//for (i = 1; i <= 1000; i++)
//{
//    int num = i;
//    bool three = false;

//    while (num != 0)
//    {
//        int digit = num % 10;
//        if (digit == 3)
//        {
//            three = true;
//            break;
//        }
//        num /= 10;
//    }

//    if (!three)
//    {
//        Console.WriteLine(i);
//    }
//}
/*
 7)  1-1000 qeder ederlerin icerisinden  ele ededleri cap etki :
     hemin ededin daxilinde 3 reqemi umumiyyetle olmasin
 */
#endregion
#region Task 8
//int lastNum = -1;
//for (int i = 1000; i >= 1; i--)
//{
//    int num = i;
//    int sum = 0;

//    while (num != 0)
//    {
//        int digit = num % 10;
//        sum += digit;
//        if (digit == 3)
//        {
//            break;
//        }
//        num /= 10;
//    }

//    if (num == 0 && sum == 3)
//    {
//        lastNum = i;
//        break;
//    }
//}

//if (lastNum != -1)
//{
//    Console.WriteLine("En son reqem " + lastNum);
//}
//else
//{
//    Console.WriteLine("Tapilmadi");
//}
/*
8)  1-1000 qeder ederlerin icerisinden,
    daxilinde 3 reqemi olmayib,
    reqemleri cemi 3 olan en sonuncu eded hansidir?
 */
#endregion
#region Task 9
//int count = 0;
//for (int i = 11; i <= 1000; i += 11)
//{
//    int num = i;
//    int sum = 0;

//    while (num != 0)
//    {
//        int digit = num % 10;
//        sum += digit;
//        num /= 10;
//    }

//    if (sum > 11)
//    {
//        count++;
//        if (count == 11)
//        {
//            Console.WriteLine("11 bolune bilen ve reqemlerin toplami 11 den boyuk olan: " + i);
//            break;
//        }
//    }
//}

//if (count < 11)
//{
//    Console.WriteLine("tapilmadi.");
//}

/*
 9)  1-1000 qeder ederlerin icerisinde
    11-e bolunub reqemleri cemi 11-den boyuk olan 11-ci eded hansidir?
 */
#endregion
#region Task 10
//int max = -1;
//for (int i = 1; i <= 1000; i++)
//{
//    int num = i;
//    int sum = 0;

//    while (num != 0)
//    {
//        int digit = num % 10;
//        sum += digit;
//        num /= 10;
//    }

//    if (sum >= 5 && sum <= 7 && i > max)
//    {
//        max = i;
//    }
//}

//if (max == -1)
//{
//    Console.WriteLine("Tapilmadi");
//}
//else
//{
//    Console.WriteLine("Netice: " + max);
//}

/*
 10) 1-1000 qeder CUT ederlerin icerisinde
    reqemleri cemi 5 ile 7 arasinda olan en boyuk eded hansidir?
 */
#endregion
#region Task 11

/*
 11) 1-1000 qeder ederlerin icerisinden  ele ededleri cap etki :
       hem polindrom olsun,
       hem ededin reqemleri daxilinde 3 olmasin
       hem ededin reqemleri cemi 10 dan boyuk olsun
 */
#endregion
#region Task 12

/*  }
 12) 1-100000 qeder ederlerin icerisinden  ele ededleri cap etki :
       hem butun reqemleri eyni olsun,
       hem reqemleri cemi 5 den boyuk olsun
       hem reqemleri arasinda 5 reqemi olmasin    
 */
#endregion
#region Task 13

/*
 13) 1-100000 qeder ederlerin icerisinden  ele ededleri cap etki :
       hem butun reqemleri yalniz tek ededlerden ibaret olsun,
       polindrom olsun,
       daxilinde minimum 1 dene 5 reqemi olsun
 */
#endregion
#region Task 14

/*
 14) 1-100000 qeder ederlerin icerisinden  ele ededleri cap etki :
       hem ededin ozunun daxilinde minimum 2 dene 5 olsun,
       hem ededin ozunun daxilinde 2 dene yanashi gelen 1 reqemi olsun
       hem ededin reqemleri cemi 7- 15 arasinda olsun.
       hem ededin reqemlerinin daxilinde 6 reqemi olmasin

 */
#endregion
#region Task 15

/*
 15)* 1-10000 qeder ederlerin icerisinden  ele ededleri cap etki :
       hem sade eded olsun
       hem ededin ozunun daxilinde 0,1,5,7,9 reqemleri olmasin
       hem ededin reqemleri ceminde 2 reqemi olmasin
 */
#endregion