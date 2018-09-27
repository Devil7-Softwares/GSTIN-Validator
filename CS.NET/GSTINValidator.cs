//==========================================================================//
//                                                                          //
//                    (C) Copyright 2018 Devil7 Softwares.                  //
//                                                                          //
// Licensed under the Apache License, Version 2.0 (the "License");          //
// you may not use this file except in compliance with the License.         //
// You may obtain a copy of the License at                                  //
//                                                                          //
//                http://www.apache.org/licenses/LICENSE-2.0                //
//                                                                          //
// Unless required by applicable law or agreed to in writing, software      //
// distributed under the License is distributed on an "AS IS" BASIS,        //
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied. //
// See the License for the specific language governing permissions and      //
// limitations under the License.                                           //
//                                                                          //
// Contributors :                                                           //
//     Dineshkumar T                                                        //
//==========================================================================//

using System;
using System.Text.RegularExpressions;

public class GSTINValidator
{
    #region "Variables/Constants"
    private const string GSTIN_REGEX = "[0-9]{2}[a-zA-Z]{5}[0-9]{4}[a-zA-Z]{1}[1-9A-Za-z]{1}[Z]{1}[0-9a-zA-Z]{1}";
    private const string CHECKSUM_CHARS = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ";
    #endregion

    #region "Subs/Functions"
    /// <summary>
    /// Method to check if a GSTIN Is valid. Checks the GSTIN format And thecheck digit Is valid for the passed input GSTIN
    /// </summary>
    /// <param name="GSTIN">GSTIN to Validate</param>
    public static bool IsValid(string GSTIN)
    {
        bool isValidFormat = false;
        GSTIN = GSTIN.Trim();
        if (string.IsNullOrEmpty(GSTIN))
            throw new Exception("GSTIN is empty");
        else if (Regex.IsMatch(GSTIN, GSTIN_REGEX))
            isValidFormat = GSTIN[GSTIN.Length - 1].Equals(GenerateCheckSum(GSTIN.Substring(0, GSTIN.Length - 1)));
        else
            throw new Exception("GSTIN doesn't match the pattern");
        return isValidFormat;
    }

    /// <summary>Generates and returns checksum digit for given GSTIN (without checksum digit)</summary>
    /// <param name="GSTIN">GSTIN without checksum digit to generate checksum digit</param>
    private static char GenerateCheckSum(string GSTIN)
    {
        int factor = 2;
        int sum = 0;
        int checkCodePoint = 0;
        char[] cpChars;
        char[] inputChars;

        if (string.IsNullOrEmpty(GSTIN))
            throw new Exception("GSTIN supplied for checkdigit calculation is null");
        cpChars = CHECKSUM_CHARS.ToCharArray();
        inputChars = GSTIN.ToUpper().ToCharArray();

        int Mod_ = cpChars.Length;
        for (int i = inputChars.Length - 1; i >= 0; i += -1)
        {
            int codePoint = -1;
            for (int j = 0; j <= cpChars.Length - 1; j++)
            {
                if (cpChars[j] == inputChars[i])
                {
                    codePoint = j;
                    break;
                }
            }
            int digit = factor * codePoint;
            factor = factor == 2 ? 1 : 2;
            digit = (digit / Mod_) + (digit % Mod_);
            sum += digit;
        }
        checkCodePoint = (Mod_ - (sum % Mod_)) % Mod_;
        return cpChars[checkCodePoint];
    }
    #endregion
}