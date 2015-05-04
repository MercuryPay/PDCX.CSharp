dsiPDCX.CSharp
===========

C# MercuryPay Integration to Datacap's dsiPDCX

3 step process to integrate to dsiPDCX.

##Step 1: Secure Device Initialization
  
This command should be performed during startup of the POS system with the optional PIN pad attached. 
It should not be performed prior to every transaction as it takes several seconds to complete with an attached PIN pad.
  
```C#
// Initialize the dsiPDCX bbect
private DSIPDCXLib.DsiPDCX _pdcx = new DSIPDCXLib.DsiPDCX();

// Create SecureDeviceInit XML, below example is for MagTek IPAD
string request = "<?xml version=\"1.0\"?>\n"
			+ "<TStream>\n"
			+ "  <Admin>\n"
			+ "    <TranType>Setup</TranType>\n"
			+ "    <TranCode>SecureDeviceInit</TranCode>\n"
			+ "    <PadType>IPAD100</PadType>\n"
			+ "    <SecureDevice>MTIPADHID</SecureDevice>\n"    
			+ "    <ComPort>0</ComPort>\n"
			+ "  </Admin>\n"
			+ "</TStream>\n";

// Process the XML request
string response = _pdcx.ProcessTransaction(request, 1, string.Empty, string.Empty);
```
  
##Step 2: Process XML Transaction

Build XML transactions and process with dsiPDCX object.

Below is a sample Credit Sale transaction.
```C#
 // MagTek IPAD Example XML
string request = "<?xml version=\"1.0\"?>\n"
			+ "<TStream>\n"
			+ "  <Transaction>\n"
			+ "    <MerchantID>019588466313922</MerchantID>\n"
			+ "    <LaneID>02</LaneID> 
			+ "    <TranType>Credit</TranType>\n"
			+ "    <TranCode>Sale</TranCode>\n"
			+ "    <InvoiceNo>10</InvoiceNo>\n"
			+ "    <RefNo>10</RefNo>\n"    
			+ "    <Frequency>OneTime</Frequency>\n"
			+ "    <RecordNo>RecordNumberRequested</RecordNo>\n"
			+ "    <PartialAuth>Allow</PartialAuth>\n"
			+ "    <Amount>\n"
			+ "      <Purchase>1.05</Purchase>\n"
			+ "    </Amount>\n"
			+ "    <SecureDevice>NONE</SecureDevice>\n"
			+ "    <ComPort>0</ComPort>\n"
			+ "    <Account>\n"
			+ "      <AcctNo>SecureDevice</AcctNo>\n"
			+ "    </Account>\n"
			+ "    <TerminalName>MPS Terminal</TerminalName>\n"
			+ "    <ShiftID>MPS Shift</ShiftID>\n"
			+ "    <OperatorID>MPS Operator</OperatorID>\n"
			+ "    <Memo>MPS PDCX Example v1.0</Memo>\n"
			+ "  </Transaction>\n"
			+ "</TStream>\n";

// Process the XML request
_pdcx.ServerIPConfig("x1.mercurydev.net;x2.mercurydev.net", processControl);
_pdcx.SetConnectTimeout((short)5);
_pdcx.SetResponseTimeout((short)60);
string response = _pdcx.ProcessTransaction(request, 1, string.Empty, string.Empty);
```

##Step 3: Parse the XML Response

Parse the XML Response using the XMLHelper.ParseXMLResponse(string xmlResponse) method.

This method returns a Dictionary&lt;string, string&gt;.

Approved transactions will have a CmdStatus equal to "Approved" or "Success".

```C#
Dictionary<string, string> responseDictionary = XMLHelper.ParseXMLResponse(xmlResponse);

if (responseDictionary.ContainsKey("CmdStatus")
    && (responseDictionary["CmdStatus"] == "Approved" || responseDictionary["CmdStatus"] == "Success"))
{
   // Approved/Success logic goes here
}
else
{
   // Declined/Error logic goes here
}
```

###©2014 Mercury Payment Systems, LLC - all rights reserved.

Disclaimer:
This software and all specifications and documentation contained herein or provided to you hereunder (the "Software") are provided free of charge strictly on an "AS IS" basis. No representations or warranties are expressed or implied, including, but not limited to, warranties of suitability, quality, merchantability, or fitness for a particular purpose (irrespective of any course of dealing, custom or usage of trade), and all such warranties are expressly and specifically disclaimed. Mercury Payment Systems shall have no liability or responsibility to you nor any other person or entity with respect to any liability, loss, or damage, including lost profits whether foreseeable or not, or other obligation for any cause whatsoever, caused or alleged to be caused directly or indirectly by the Software. Use of the Software signifies agreement with this disclaimer notice.


![Analytics](https://ga-beacon.appspot.com/UA-60858025-11/PDCX.CSharp/readme?pixel)
