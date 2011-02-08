using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using com.google.zxing;
using com.google.zxing.common;
using System.Collections;
using System.Drawing;

namespace zxing.Tests
{
    public abstract class BarCodeTest
    {
        public Result RecognizeBarCode(Bitmap bmp, ArrayList formats, Boolean pureBarCode = false, Boolean tryHarder = false)
        {
            Reader reader = new MultiFormatReader();

            var source = new RGBLuminanceSource(bmp, bmp.Width, bmp.Height);
            Binarizer binarizer = new HybridBinarizer(source);
            Hashtable table = new Hashtable();
            table.Add(DecodeHintType.PURE_BARCODE, pureBarCode);
            table.Add(DecodeHintType.TRY_HARDER, tryHarder);
            table.Add(DecodeHintType.POSSIBLE_FORMATS, formats);
            BinaryBitmap binBmp = new BinaryBitmap(binarizer);

            Result result = reader.decode(binBmp, table);
            return result;
        }
    }
}
