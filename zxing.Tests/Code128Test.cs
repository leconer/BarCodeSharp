using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using com.google.zxing;
using System.Drawing;
using com.google.zxing.common;
using System.Collections;
using System.IO;
using System.Reflection;
using System.Diagnostics;

namespace zxing.Tests
{
    [TestClass]
    [DeploymentItem("BarCodeImages\\code128.gif")]
    public class Code128Test : BarCodeTest
    {
        string m_BarcodeFile = "code128.gif";

        [TestMethod]
        public void Given_Code128_encoded_bar_code_When_looking_for_Code128_encoded_barcode_Then_one_barcode_should_be_recognized()
        {
            var bmp = new Bitmap(m_BarcodeFile);
            var result = RecognizeBarCode(bmp, new ArrayList() { BarcodeFormat.CODE_128 });
            Assert.AreEqual(result.Text, "Code 128");

            result = RecognizeBarCode(bmp, new ArrayList() { BarcodeFormat.CODE_128 }, true);
            Assert.AreEqual(result.Text, "Code 128");

            result = RecognizeBarCode(bmp, new ArrayList() { BarcodeFormat.CODE_128 }, true, true);
            Assert.AreEqual(result.Text, "Code 128");

            
        }

        [TestMethod]
        public void Given_Code128_encoded_barcode_When_looking_for_all_barcode_types_Then_one_barcode_should_be_recognized()
        {
            var bmp = new Bitmap(m_BarcodeFile);
            var result = RecognizeBarCode(bmp, new ArrayList() { BarcodeFormat.CODE_128, BarcodeFormat.CODE_39, BarcodeFormat.DATAMATRIX, BarcodeFormat.EAN_13, BarcodeFormat.EAN_8, BarcodeFormat.ITF, BarcodeFormat.PDF417, BarcodeFormat.QR_CODE, BarcodeFormat.UPC_A, BarcodeFormat.UPC_E });
            Assert.AreEqual(result.Text, "Code 128");

            result = RecognizeBarCode(bmp, new ArrayList() { BarcodeFormat.CODE_128, BarcodeFormat.CODE_39, BarcodeFormat.DATAMATRIX, BarcodeFormat.EAN_13, BarcodeFormat.EAN_8, BarcodeFormat.ITF, BarcodeFormat.PDF417, BarcodeFormat.QR_CODE, BarcodeFormat.UPC_A, BarcodeFormat.UPC_E }, true);
            Assert.AreEqual(result.Text, "Code 128");

            result = RecognizeBarCode(bmp, new ArrayList() { BarcodeFormat.CODE_128, BarcodeFormat.CODE_39, BarcodeFormat.DATAMATRIX, BarcodeFormat.EAN_13, BarcodeFormat.EAN_8, BarcodeFormat.ITF, BarcodeFormat.PDF417, BarcodeFormat.QR_CODE, BarcodeFormat.UPC_A, BarcodeFormat.UPC_E }, true, true);
            Assert.AreEqual(result.Text, "Code 128");
        }

        [TestMethod]
        public void Given_Code128_encoded_bar_code_When_looking_for_Code39_encoded_bar_code_Then_no_bar_code_should_be_recognized()
        {
            var bmp = new Bitmap(m_BarcodeFile);
            var result = RecognizeBarCode(bmp, new ArrayList() { BarcodeFormat.CODE_39 });
            Assert.AreEqual(result, null);

            result = RecognizeBarCode(bmp, new ArrayList() { BarcodeFormat.CODE_39 }, true);
            Assert.AreEqual(result, null);

            result = RecognizeBarCode(bmp, new ArrayList() { BarcodeFormat.CODE_39 }, true, true);
            Assert.AreEqual(result, null);
        }
    }
}
