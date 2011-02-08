/*
* Copyright 2007 ZXing authors
*
* Licensed under the Apache License, Version 2.0 (the "License");
* you may not use this file except in compliance with the License.
* You may obtain a copy of the License at
*
*      http://www.apache.org/licenses/LICENSE-2.0
*
* Unless required by applicable law or agreed to in writing, software
* distributed under the License is distributed on an "AS IS" BASIS,
* WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
* See the License for the specific language governing permissions and
* limitations under the License.
*/
using System;
using System.Collections;
using System.Linq;
namespace com.google.zxing.common
{

    public static class BitArrayExtensions
    {
        public static bool isRange(this BitArray array, int start, int end, bool value_Renamed)
        {
            for (int i = start; i < end; i++)
            {
                if (array[i] == !value_Renamed) return false;
            }
            return true;
        }

        public static int Size(this BitArray array) { return array.Length; }
        public static bool get_Renamed(this BitArray array, int i) { return array[i]; }
        public static void set_Renamed(this BitArray array, int i) { array[i] = true; }
        public static void flip(this BitArray array, int i) { array[i] = !array[i]; }

        public static void clear(this BitArray array)
        {
            array.SetAll(false);
        }
        public static void reverse(this BitArray array)
        {
            array.Not();
        }
    }
}