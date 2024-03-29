import unittest
import primenum
import io
import sys


class MyTestCase(unittest.TestCase):
    def test_num_valid_true(self):
        self.assertTrue(primenum.is_num_valid("9"))

    def test_num_empty(self):
        suppress_text = io.StringIO()
        sys.stdout = suppress_text
        self.assertFalse(primenum.is_num_valid(""))
        sys.stdout = sys.__stdout__

    def test_num_zero(self):
        suppress_text = io.StringIO()
        sys.stdout = suppress_text
        self.assertFalse(primenum.is_num_valid("0"))
        sys.stdout = sys.__stdout__

    def test_num_one(self):
        suppress_text = io.StringIO()
        sys.stdout = suppress_text
        self.assertFalse(primenum.is_num_valid("1"))
        sys.stdout = sys.__stdout__    
    
    def test_num_valid_false(self):
        suppress_text = io.StringIO()
        sys.stdout = suppress_text
        self.assertFalse(primenum.is_num_valid("e"))
        sys.stdout = sys.__stdout__

    def test_num_is_prime(self):
        self.assertEqual("23 is a prime number", primenum.prime_or_not("23"))

    def test_num_is_prime_false(self):
        self.assertNotEqual("39 is a prime number", primenum.prime_or_not("39"))

    def test_num_is_not_prime(self):
        self.assertEqual("15 is not a prime number as it is divisible by 3", primenum.prime_or_not("15"))

    def test_num_is_not_prime_false(self):
        self.assertNotEqual("19 is not a prime number", primenum.prime_or_not("19"))

    

if __name__=="__main__":
    unittest.main()