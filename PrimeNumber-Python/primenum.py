def get_number():
    num = input("Enter a number: ")
    return num

def is_num_valid(num):
    if num =="":
        print("Number input is empty")
        return False
    if num=="0":
        print("0 is not a valid number for a prime number")
        return False
    if num=="1":
        print("1 is not a valid number for a prime number")
        return False
    if not num.isnumeric():
        print("Number must be numerical")
        return False
    return True

def prime_or_not(x):
    prime =""
    num = int(x)
    flag = False
    '''
    count = 2
    while(num % count !=0):
        if count == num:
            prime = str(num) + " is a prime number"
            break
        if count:
            prime = str(num) + " is not a prime number"
            break
        count += 1'''
    if num > 1:
        for i in range(2, num):
            if (num % i) ==0:
                flag = True
                break
    if flag:
        prime=str(num)+" is not a prime number"
    else:
        prime=str(num)+" is a prime number"
    return prime