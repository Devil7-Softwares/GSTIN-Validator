
# GSTIN-Validator
GSTIN Validator with checksum validation.

**What is GSTIN..?**

GSTIN refers to GST Identification Number assigned to every GST registered dealer in India.

**Format/Pattern of GSTIN**

GSTIN is a 15 digit unique code which is PAN-based. The structure or format of 15 digit GSTIN will look like below.

![Format of GSTIN](https://raw.githubusercontent.com/Devil7-Softwares/GSTIN-Validator/master/.images/gst-format.jpg)

 - **Digits 1 & 2 :** State Codes - the state code in the GST registration number represent the following states: [Refer
   Here](http://www.ddvat.gov.in/docs/List%20of%20State%20Code.pdf)
   
 -    **Digits 3 – 12 :** PAN -  represent the PAN of the entity, so that there is a connection between the GST and the PAN database.
   
 -    **Digit 13 :**  Entity Code -  this is alpha-numeric (1-9 and then A-Z) and is assigned based on the number of registrations a legal
   entity (having the same PAN) has within one State
   
 -    **Digit 14 :** Static Z
   
 -    **Digit 15 :** Checksum -  Check Digit obtained from ['luhn mod 36'](https://en.wikipedia.org/wiki/Luhn_mod_N_algorithm)

**Validating GSTIN in .NET**

 - [Visual Basic .NET](https://github.com/Devil7-Softwares/GSTIN-Validator/blob/master/VB.NET/GSTINValidator.vb)
 - [C# .NET](https://github.com/Devil7-Softwares/GSTIN-Validator/blob/master/CS.NET/GSTINValidator.cs)
 
 **Example/Demo Application**

 - [Download Here](https://github.com/Devil7-Softwares/GSTIN-Validator/releases/download/v1.0.0/GSTIN_Validator-Example.exe)