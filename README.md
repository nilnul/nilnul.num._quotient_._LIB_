# nilnul Quotient
codename: nilnul.num.\_quotient\_.\_LIB_

A library for quotient numbers.

## Highlights
To create a quotient number:
```var q=new nilnul.num.quotient_.DenomNonnil(3,2); ```

To convert a double to a quotient number:

```var d=nilnul.num.quotient_.radix.ext.errable_.ieee_.bin.to_._ToRationalX.ToSignificed(-1.23d);```

To repesent a quotient in scientific notation:
```nilnul.num.quotient_._radix.basic.indiced.significed_.Dec(123,-5)```
//that would be 123*10^5

To represent a fractional with arbitrary precision:
```	nilnul.num.quotient_.radix_.floaty_.dec._ParseX.Parse(s).toDenomNonnil("164.40845267098899285")```

For periodic frational:

```nilnul.num.quotient_.radix_.floaty.recur_.mantissaed_.dec.of_._OfQuotientX.ToCyclic(this nilnul.num.quotient_.DenomNonnil byNeg);```
//would convert a quotient into a decimal periodic frational;

For continued fraction:
```
var r = nilnul.num.integer.str_.started_.nonhead8positive.fractile_.nonneg.of_.ofQuotient_._ByEuclidAlgorithmX._AsAdders_01nonneg(43,19).ToArray();

Assert.IsTrue(
  nilnul.obj.str.Eq<BigInteger>.Singleton.Equals(
    r,
    new BigInteger[] {
      2,3,1,4
    }
  )
);
```
For a closed quotient interval that is nested, and cauchy (in other words, becoming arbitrary small):
```nilnul.num.quotient_.denomNonnil.bound_.closed.stream_.nested_.CauchyI```
//this would be used later by nilnulReal (`nilnul.num._real_._LIB_`) to define real numbers.

For other usage, you can also try some unit tests in `nilnul.num._real_._TEST_`

## nuget package
You can directly install this package from nuget.org.
