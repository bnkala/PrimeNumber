import unittest
import primenum

class MyTestCase(unittest.TestCase):
    '''def test_num_valid_true(self):
        self.assertTrue(primenum.is_num_valid("9"))

    def test_num_empty(self):
        self.assertFalse(primenum.is_num_valid(""))

    def test_num_zero(self):
        self.assertFalse(primenum.is_num_valid("0"))

    def test_num_one(self):
        self.assertFalse(primenum.is_num_valid("1"))    
    
    def test_num_valid_false(self):
        self.assertFalse(primenum.is_num_valid("e"))'''

    def test_num_is_prime(self):
        self.assertEqual("23 is a prime number", primenum.prime_or_not("23"))

    def test_num_is_prime_false(self):
        self.assertNotEqual("39 is a prime number", primenum.prime_or_not("39"))

    def test_num_is_not_prime(self):
        self.assertEqual("15 is not a prime number", primenum.prime_or_not("15"))

    def test_num_is_not_prime_false(self):
        self.assertNotEqual("19 is not a prime number", primenum.prime_or_not("19"))

    

if __name__=="__main__":
    unittest.main()