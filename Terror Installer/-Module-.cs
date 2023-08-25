//using System;
//using System.Diagnostics;
//using System.IO;
//using System.Reflection;
//using System.Runtime.InteropServices;
//using System.Threading;

//// Token: 0x02000001 RID: 1
//internal class <Module>
//{
//    // Token: 0x06000001 RID: 1 RVA: 0x00002D4C File Offset: 0x00000F4C
//unsafe static < Module > ()

//    {

//        < Module >.smethod_2();
//    Module module = typeof(< Module >).Module;
//    byte* ptr = (byte*)((void*)Marshal.GetHINSTANCE(module));
//    byte* ptr2 = ptr + 60;
//    ptr2 = ptr + *(uint*)ptr2;
//    ptr2 += 6;
//    ushort num = *(ushort*)ptr2;
//    ptr2 += 14;
//    ushort num2 = *(ushort*)ptr2;
//    ptr2 = ptr2 + 4 + num2;
//    byte* ptr3 = stackalloc byte[(UIntPtr)11];
//    MethodInfo method;
//    if (module.FullyQualifiedName[0] == '<')
//    {
//        uint num3 = *(uint*)(ptr2 - 16);
//        uint num4 = *(uint*)(ptr2 - 120);
//        uint[] array = new uint[(int)num];
//        uint[] array2 = new uint[(int)num];
//        uint[] array3 = new uint[(int)num];
//        for (int i = 0; i < (int)num; i++)
//        {

//                < Module >.VirtualProtect(ptr2, 8, 64U, ref method);
//            Marshal.Copy(new byte[8], 0, (IntPtr)((void*)ptr2), 8);
//            array[i] = *(uint*)(ptr2 + 12);
//            array2[i] = *(uint*)(ptr2 + 8);
//            array3[i] = *(uint*)(ptr2 + 20);
//            ptr2 += 40;
//        }
//        if (num4 != 0U)
//        {
//            for (int j = 0; j < (int)num; j++)
//            {
//                if (array[j] <= num4 && num4 < array[j] + array2[j])
//                {
//                    num4 = num4 - array[j] + array3[j];
//                IL_366:
//                    byte* ptr4 = ptr + num4;
//                    uint num5 = *(uint*)ptr4;
//                    for (int k = 0; k < (int)num; k++)
//                    {
//                        if (array[k] <= num5 && num5 < array[k] + array2[k])
//                        {
//                            num5 = num5 - array[k] + array3[k];
//                        IL_3AD:
//                            byte* ptr5 = ptr + num5;
//                            uint num6 = *(uint*)(ptr4 + 12);
//                            for (int l = 0; l < (int)num; l++)
//                            {
//                                if (array[l] <= num6 && num6 < array[l] + array2[l])
//                                {
//                                    num6 = num6 - array[l] + array3[l];
//                                IL_3F7:
//                                    uint num7 = *(uint*)ptr5 + 2U;
//                                    for (int m = 0; m < (int)num; m++)
//                                    {
//                                        if (array[m] <= num7 && num7 < array[m] + array2[m])
//                                        {
//                                            num7 = num7 - array[m] + array3[m];
//                                        IL_439:

//                                                < Module >.VirtualProtect(ptr + num6, 11, 64U, ref method);
//                                            *(int*)ptr3 = 1818522734;
//                                            *(int*)(ptr3 + 4) = 1818504812;
//                                            *(short*)(ptr3 + (IntPtr)4 * 2) = 108;
//                                            ptr3[10] = 0;
//                                            for (int n = 0; n < 11; n++)
//                                            {
//                                                (ptr + num6)[n] = ptr3[n];
//                                            }

//                                                < Module >.VirtualProtect(ptr + num7, 11, 64U, ref method);
//                                            *(int*)ptr3 = 1866691662;
//                                            *(int*)(ptr3 + 4) = 1852404846;
//                                            *(short*)(ptr3 + (IntPtr)4 * 2) = 25973;
//                                            ptr3[10] = 0;
//                                            for (int num8 = 0; num8 < 11; num8++)
//                                            {
//                                                (ptr + num7)[num8] = ptr3[num8];
//                                            }
//                                            goto IL_4E4;
//                                        }
//                                    }
//                                    goto IL_439;
//                                }
//                            }
//                            goto IL_3F7;
//                        }
//                    }
//                    goto IL_3AD;
//                }
//            }
//            goto IL_366;
//        }
//    IL_4E4:
//        for (int num9 = 0; num9 < (int)num; num9++)
//        {
//            if (array[num9] <= num3 && num3 < array[num9] + array2[num9])
//            {
//                num3 = num3 - array[num9] + array3[num9];
//            IL_51F:
//                byte* ptr6 = ptr + num3;

//                    < Module >.VirtualProtect(ptr6, 72, 64U, ref method);
//                uint num10 = *(uint*)(ptr6 + 8);
//                for (int num11 = 0; num11 < (int)num; num11++)
//                {
//                    if (array[num11] <= num10 && num10 < array[num11] + array2[num11])
//                    {
//                        num10 = num10 - array[num11] + array3[num11];
//                    IL_576:
//                        *(int*)ptr6 = 0;
//                        *(int*)(ptr6 + 4) = 0;
//                        *(int*)(ptr6 + (IntPtr)2 * 4) = 0;
//                        *(int*)(ptr6 + (IntPtr)3 * 4) = 0;
//                        byte* ptr7 = ptr + num10;

//                            < Module >.VirtualProtect(ptr7, 4, 64U, ref method);
//                        *(int*)ptr7 = 0;
//                        ptr7 += 12;
//                        ptr7 += *(uint*)ptr7;
//                        ptr7 = (ptr7 + 7L & -4L);
//                        ptr7 += 2;
//                        ushort num12 = (ushort)(*ptr7);
//                        ptr7 += 2;
//                        int num13 = 0;
//                    IL_678:
//                        while (num13 < (int)num12)
//                        {

//                                < Module >.VirtualProtect(ptr7, 8, 64U, ref method);
//                            ptr7 += 4;
//                            ptr7 += 4;
//                            int num14 = 0;
//                            while (num14 < 8)
//                            {

//                                    < Module >.VirtualProtect(ptr7, 4, 64U, ref method);
//                                *ptr7 = 0;
//                                ptr7++;
//                                if (*ptr7 != 0)
//                                {
//                                    *ptr7 = 0;
//                                    ptr7++;
//                                    if (*ptr7 != 0)
//                                    {
//                                        *ptr7 = 0;
//                                        ptr7++;
//                                        if (*ptr7 != 0)
//                                        {
//                                            *ptr7 = 0;
//                                            ptr7++;
//                                            num14++;
//                                            continue;
//                                        }
//                                        ptr7++;
//                                    }
//                                    else
//                                    {
//                                        ptr7 += 2;
//                                    }
//                                }
//                                else
//                                {
//                                    ptr7 += 3;
//                                }
//                            IL_672:
//                                num13++;
//                                goto IL_678;
//                            }
//                            goto IL_672;
//                        }
//                        goto IL_681;
//                    }
//                }
//                goto IL_576;
//            }
//        }
//        goto IL_51F;
//    }
//    byte* ptr8 = ptr + *(uint*)(ptr2 - 16);
//    if (*(uint*)(ptr2 - 120) != 0U)
//    {
//        byte* ptr9 = ptr + *(uint*)(ptr2 - 120);
//        byte* ptr10 = ptr + *(uint*)ptr9;
//        byte* ptr11 = ptr + *(uint*)(ptr9 + 12);
//        byte* ptr12 = ptr + *(uint*)ptr10 + 2;

//            < Module >.VirtualProtect(ptr11, 11, 64U, ref method);
//        *(int*)ptr3 = 1818522734;
//        *(int*)(ptr3 + 4) = 1818504812;
//        *(short*)(ptr3 + (IntPtr)4 * 2) = 108;
//        ptr3[10] = 0;
//        for (int num15 = 0; num15 < 11; num15++)
//        {
//            ptr11[num15] = ptr3[num15];
//        }

//            < Module >.VirtualProtect(ptr12, 11, 64U, ref method);
//        *(int*)ptr3 = 1866691662;
//        *(int*)(ptr3 + 4) = 1852404846;
//        *(short*)(ptr3 + (IntPtr)4 * 2) = 25973;
//        ptr3[10] = 0;
//        for (int num16 = 0; num16 < 11; num16++)
//        {
//            ptr12[num16] = ptr3[num16];
//        }
//    }
//    for (int num17 = 0; num17 < (int)num; num17++)
//    {

//            < Module >.VirtualProtect(ptr2, 8, 64U, ref method);
//        Marshal.Copy(new byte[8], 0, (IntPtr)((void*)ptr2), 8);
//        ptr2 += 40;
//    }

//        < Module >.VirtualProtect(ptr8, 72, 64U, ref method);
//    byte* ptr13 = ptr + *(uint*)(ptr8 + 8);
//    *(int*)ptr8 = 0;
//    *(int*)(ptr8 + 4) = 0;
//    *(int*)(ptr8 + (IntPtr)2 * 4) = 0;
//    *(int*)(ptr8 + (IntPtr)3 * 4) = 0;

//        < Module >.VirtualProtect(ptr13, 4, 64U, ref method);
//    *(int*)ptr13 = 0;
//    ptr13 += 12;
//    ptr13 += *(uint*)ptr13;
//    ptr13 = (ptr13 + 7L & -4L);
//    ptr13 += 2;
//    ushort num18 = (ushort)(*ptr13);
//    ptr13 += 2;
//    int num19 = 0;
//IL_292:
//    while (num19 < (int)num18)
//    {

//            < Module >.VirtualProtect(ptr13, 8, 64U, ref method);
//        ptr13 += 4;
//        ptr13 += 4;
//        int num20 = 0;
//        while (num20 < 8)
//        {

//                < Module >.VirtualProtect(ptr13, 4, 64U, ref method);
//            *ptr13 = 0;
//            ptr13++;
//            if (*ptr13 != 0)
//            {
//                *ptr13 = 0;
//                ptr13++;
//                if (*ptr13 != 0)
//                {
//                    *ptr13 = 0;
//                    ptr13++;
//                    if (*ptr13 != 0)
//                    {
//                        *ptr13 = 0;
//                        ptr13++;
//                        num20++;
//                        continue;
//                    }
//                    ptr13++;
//                }
//                else
//                {
//                    ptr13 += 2;
//                }
//            }
//            else
//            {
//                ptr13 += 3;
//            }
//        IL_28C:
//            num19++;
//            goto IL_292;
//        }
//        goto IL_28C;
//    }
//IL_681:
//    method = typeof(Environment).GetMethod("GetEnvironmentVariable", new Type[]
//    {
//            typeof(string)
//    });
//    if (method != null && "1".Equals(method.Invoke(null, new object[]
//    {
//            "COR_ENABLE_PROFILING"
//    })))
//    {
//        Environment.FailFast(null);
//    }
//    new Thread(new ParameterizedThreadStart(< Module >.smethod_0))
//    {
//        IsBackground = true
//    }.Start(null);
//}

//// Token: 0x06000002 RID: 2 RVA: 0x0000344C File Offset: 0x0000164C
//private static void smethod_0(object object_0)
//{
//    Thread thread;
//    if ((thread = (object_0 as Thread)) == null)
//    {
//        thread = new Thread(new ParameterizedThreadStart(< Module >.smethod_0));
//        thread.IsBackground = true;
//        thread.Start(Thread.CurrentThread);
//        Thread.Sleep(500);
//    }
//    for (; ; )
//    {
//        if (Debugger.IsAttached)
//        {
//            goto IL_3A;
//        }
//        if (Debugger.IsLogging())
//        {
//            goto IL_3A;
//        }
//    IL_40:
//        if (!thread.IsAlive)
//        {
//            Environment.FailFast(null);
//        }
//        Thread.Sleep(1000);
//        continue;
//    IL_3A:
//        Environment.FailFast(null);
//        goto IL_40;
//    }
//}

//// Token: 0x06000003 RID: 3
//[DllImport("kernel32.dll")]
//internal unsafe static extern bool VirtualProtect(byte* pByte_0, int int_0, uint uint_0, ref uint uint_1);

//// Token: 0x06000004 RID: 4 RVA: 0x000034C4 File Offset: 0x000016C4
//internal static byte[] smethod_1(byte[] byte_0)
//{
//    MemoryStream memoryStream = new MemoryStream(byte_0);

//        < Module >.Class1 @class = new < Module >.Class1();
//    byte[] array = new byte[5];
//    memoryStream.Read(array, 0, 5);
//    @class.method_5(array);
//    long num = 0L;
//    for (int i = 0; i < 8; i++)
//    {
//        int num2 = memoryStream.ReadByte();
//        num |= (long)((long)((ulong)((byte)num2)) << 8 * i);
//    }
//    byte[] array2 = new byte[(int)num];
//    MemoryStream stream_ = new MemoryStream(array2, true);
//    long long_ = memoryStream.Length - 13L;
//    @class.method_4(memoryStream, stream_, long_, num);
//    return array2;
//}

//// Token: 0x06000005 RID: 5 RVA: 0x00003558 File Offset: 0x00001758
//internal static void smethod_2()
//{
//    uint num = 96U;
//    uint[] array = new uint[]
//    {
//            2291510520U,
//            412215307U,
//            1351953582U,
//            3367086092U,
//            731196472U,
//            3213972715U,
//            3798689885U,
//            3218278168U,
//            425741022U,
//            664235031U,
//            2522353488U,
//            3563670749U,
//            857182419U,
//            3203281390U,
//            880351454U,
//            2326869512U,
//            3478152073U,
//            981082144U,
//            2866074347U,
//            3124687295U,
//            1142236476U,
//            2060400849U,
//            1253534985U,
//            3822655039U,
//            2687616321U,
//            1449433771U,
//            242792406U,
//            1767174404U,
//            2255481820U,
//            1008954171U,
//            3704941900U,
//            1077291916U,
//            3029096480U,
//            371415296U,
//            3001571337U,
//            2407805464U,
//            2382534308U,
//            2572943488U,
//            611273591U,
//            3852061418U,
//            2884510265U,
//            3121007009U,
//            463561074U,
//            1371011275U,
//            2584231851U,
//            35526308U,
//            3334911959U,
//            2140811036U,
//            1525678987U,
//            3786764696U,
//            2664547396U,
//            4081810338U,
//            3078496724U,
//            25695748U,
//            3036409365U,
//            508609480U,
//            3261146376U,
//            509029248U,
//            3041876117U,
//            1409008410U,
//            199932162U,
//            76389923U,
//            1676331414U,
//            267765091U,
//            3245906113U,
//            2208581037U,
//            432749555U,
//            862011741U,
//            495857717U,
//            664473368U,
//            3500559100U,
//            1360217006U,
//            3030785943U,
//            3699305699U,
//            106010820U,
//            2557055064U,
//            1232347648U,
//            4094984630U,
//            2593237718U,
//            3309981051U,
//            3031869530U,
//            2488954640U,
//            432749426U,
//            862011741U,
//            495857717U,
//            664473368U,
//            3500559100U,
//            1360217006U,
//            3030785943U,
//            3699305699U,
//            106010820U,
//            2557055064U,
//            1232347648U,
//            4094984630U,
//            2593237718U,
//            3309981051U
//    };
//    uint[] array2 = new uint[16];
//    uint num2 = 1083680793U;
//    for (int i = 0; i < 16; i++)
//    {
//        num2 ^= num2 >> 13;
//        num2 ^= num2 << 25;
//        num2 ^= num2 >> 27;
//        array2[i] = num2;
//    }
//    int num3 = 0;
//    int num4 = 0;
//    uint[] array3 = new uint[16];
//    byte[] array4 = new byte[num * 4U];
//    while ((long)num3 < (long)((ulong)num))
//    {
//        for (int j = 0; j < 16; j++)
//        {
//            array3[j] = array[num3 + j];
//        }
//        array3[0] = (array3[0] ^ array2[0]);
//        array3[1] = (array3[1] ^ array2[1]);
//        array3[2] = (array3[2] ^ array2[2]);
//        array3[3] = (array3[3] ^ array2[3]);
//        array3[4] = (array3[4] ^ array2[4]);
//        array3[5] = (array3[5] ^ array2[5]);
//        array3[6] = (array3[6] ^ array2[6]);
//        array3[7] = (array3[7] ^ array2[7]);
//        array3[8] = (array3[8] ^ array2[8]);
//        array3[9] = (array3[9] ^ array2[9]);
//        array3[10] = (array3[10] ^ array2[10]);
//        array3[11] = (array3[11] ^ array2[11]);
//        array3[12] = (array3[12] ^ array2[12]);
//        array3[13] = (array3[13] ^ array2[13]);
//        array3[14] = (array3[14] ^ array2[14]);
//        array3[15] = (array3[15] ^ array2[15]);
//        for (int k = 0; k < 16; k++)
//        {
//            uint num5 = array3[k];
//            array4[num4++] = (byte)num5;
//            array4[num4++] = (byte)(num5 >> 8);
//            array4[num4++] = (byte)(num5 >> 16);
//            array4[num4++] = (byte)(num5 >> 24);
//            array2[k] ^= num5;
//        }
//        num3 += 16;
//    }

//        < Module >.assembly_0 = Assembly.Load(< Module >.smethod_1(array4));
//    AppDomain.CurrentDomain.ResourceResolve += < Module >.smethod_3;
//}

//// Token: 0x06000006 RID: 6 RVA: 0x0000226C File Offset: 0x0000046C
//internal static Assembly smethod_3(object object_0, ResolveEventArgs resolveEventArgs_0)
//{
//    if (Array.IndexOf<string>(< Module >.assembly_0.GetManifestResourceNames(), resolveEventArgs_0.Name) != -1)
//    {
//        return < Module >.assembly_0;
//    }
//    return null;
//}

//// Token: 0x04000001 RID: 1
//internal static Assembly assembly_0;

//// Token: 0x04000002 RID: 2 RVA: 0x00002048 File Offset: 0x00000248
//internal static < Module >.Struct4 struct4_0;

//// Token: 0x02000002 RID: 2
//internal struct Struct0
//{
//    // Token: 0x06000007 RID: 7 RVA: 0x0000228D File Offset: 0x0000048D
//    internal void method_0()
//    {
//        this.uint_0 = 1024U;
//    }

//    // Token: 0x06000008 RID: 8 RVA: 0x00003764 File Offset: 0x00001964
//    internal uint method_1(<Module>.Class0 class0_0)
//    {
//        uint num = (class0_0.uint_1 >> 11) * this.uint_0;
//        if (class0_0.uint_0 < num)
//        {
//            class0_0.uint_1 = num;
//            this.uint_0 += 2048U - this.uint_0 >> 5;
//            if (class0_0.uint_1 < 16777216U)
//            {
//                class0_0.uint_0 = (class0_0.uint_0 << 8 | (uint)((byte)class0_0.stream_0.ReadByte()));
//                class0_0.uint_1 <<= 8;
//            }
//            return 0U;
//        }
//        class0_0.uint_1 -= num;
//        class0_0.uint_0 -= num;
//        this.uint_0 -= this.uint_0 >> 5;
//        if (class0_0.uint_1 < 16777216U)
//        {
//            class0_0.uint_0 = (class0_0.uint_0 << 8 | (uint)((byte)class0_0.stream_0.ReadByte()));
//            class0_0.uint_1 <<= 8;
//        }
//        return 1U;
//    }

//    // Token: 0x04000003 RID: 3
//    internal uint uint_0;
//}

//// Token: 0x02000003 RID: 3
//internal struct Struct1
//{
//    // Token: 0x06000009 RID: 9 RVA: 0x0000229A File Offset: 0x0000049A
//    internal Struct1(int int_1)
//    {
//        this.int_0 = int_1;
//        this.struct0_0 = new < Module >.Struct0[1 << int_1];
//    }

//    // Token: 0x0600000A RID: 10 RVA: 0x00003850 File Offset: 0x00001A50
//    internal void method_0()
//    {
//        uint num = 1U;
//        while ((ulong)num < (ulong)(1L << (this.int_0 & 31)))
//        {
//            this.struct0_0[(int)num].method_0();
//            num += 1U;
//        }
//    }

//    // Token: 0x0600000B RID: 11 RVA: 0x00003888 File Offset: 0x00001A88
//    internal uint method_1(<Module>.Class0 class0_0)
//    {
//        uint num = 1U;
//        for (int i = this.int_0; i > 0; i--)
//        {
//            num = (num << 1) + this.struct0_0[(int)num].method_1(class0_0);
//        }
//        return num - (1U << this.int_0);
//    }

//    // Token: 0x0600000C RID: 12 RVA: 0x000038CC File Offset: 0x00001ACC
//    internal uint method_2(<Module>.Class0 class0_0)
//    {
//        uint num = 1U;
//        uint num2 = 0U;
//        for (int i = 0; i < this.int_0; i++)
//        {
//            uint num3 = this.struct0_0[(int)num].method_1(class0_0);
//            num <<= 1;
//            num += num3;
//            num2 |= num3 << i;
//        }
//        return num2;
//    }

//    // Token: 0x0600000D RID: 13 RVA: 0x00003914 File Offset: 0x00001B14
//    internal static uint smethod_0(<Module>.Struct0[] struct0_1, uint uint_0, <Module>.Class0 class0_0, int int_1)
//    {
//        uint num = 1U;
//        uint num2 = 0U;
//        for (int i = 0; i < int_1; i++)
//        {
//            uint num3 = struct0_1[(int)(uint_0 + num)].method_1(class0_0);
//            num <<= 1;
//            num += num3;
//            num2 |= num3 << i;
//        }
//        return num2;
//    }

//    // Token: 0x04000004 RID: 4
//    internal readonly <Module>.Struct0[] struct0_0;

//    // Token: 0x04000005 RID: 5
//    internal readonly int int_0;
//}

//// Token: 0x02000004 RID: 4
//internal class Class0
//{
//    // Token: 0x0600000E RID: 14 RVA: 0x00003954 File Offset: 0x00001B54
//    internal void method_0(Stream stream_1)
//    {
//        this.stream_0 = stream_1;
//        this.uint_0 = 0U;
//        this.uint_1 = uint.MaxValue;
//        for (int i = 0; i < 5; i++)
//        {
//            this.uint_0 = (this.uint_0 << 8 | (uint)((byte)this.stream_0.ReadByte()));
//        }
//    }

//    // Token: 0x0600000F RID: 15 RVA: 0x000022B4 File Offset: 0x000004B4
//    internal void method_1()
//    {
//        this.stream_0 = null;
//    }

//    // Token: 0x06000010 RID: 16 RVA: 0x000022BD File Offset: 0x000004BD
//    internal void method_2()
//    {
//        while (this.uint_1 < 16777216U)
//        {
//            this.uint_0 = (this.uint_0 << 8 | (uint)((byte)this.stream_0.ReadByte()));
//            this.uint_1 <<= 8;
//        }
//    }

//    // Token: 0x06000011 RID: 17 RVA: 0x000039A0 File Offset: 0x00001BA0
//    internal uint method_3(int int_0)
//    {
//        uint num = this.uint_1;
//        uint num2 = this.uint_0;
//        uint num3 = 0U;
//        for (int i = int_0; i > 0; i--)
//        {
//            num >>= 1;
//            uint num4 = num2 - num >> 31;
//            num2 -= (num & num4 - 1U);
//            num3 = (num3 << 1 | 1U - num4);
//            if (num < 16777216U)
//            {
//                num2 = (num2 << 8 | (uint)((byte)this.stream_0.ReadByte()));
//                num <<= 8;
//            }
//        }
//        this.uint_1 = num;
//        this.uint_0 = num2;
//        return num3;
//    }

//    // Token: 0x06000012 RID: 18 RVA: 0x000022F8 File Offset: 0x000004F8
//    internal Class0()
//    {
//    }

//    // Token: 0x04000006 RID: 6
//    internal uint uint_0;

//    // Token: 0x04000007 RID: 7
//    internal uint uint_1;

//    // Token: 0x04000008 RID: 8
//    internal Stream stream_0;
//}

//// Token: 0x02000005 RID: 5
//internal class Class1
//{
//    // Token: 0x06000013 RID: 19 RVA: 0x00003A14 File Offset: 0x00001C14
//    internal Class1()
//    {
//        this.uint_0 = uint.MaxValue;
//        int num = 0;
//        while ((long)num < 4L)
//        {
//            this.struct1_0[num] = new < Module >.Struct1(6);
//            num++;
//        }
//    }

//    // Token: 0x06000014 RID: 20 RVA: 0x00003B08 File Offset: 0x00001D08
//    internal void method_0(uint uint_3)
//    {
//        if (this.uint_0 != uint_3)
//        {
//            this.uint_0 = uint_3;
//            this.uint_1 = Math.Max(this.uint_0, 1U);
//            uint uint_4 = Math.Max(this.uint_1, 4096U);
//            this.class4_0.method_0(uint_4);
//        }
//    }

//    // Token: 0x06000015 RID: 21 RVA: 0x00002300 File Offset: 0x00000500
//    internal void method_1(int int_0, int int_1)
//    {
//        this.class3_0.method_0(int_0, int_1);
//    }

//    // Token: 0x06000016 RID: 22 RVA: 0x00003B54 File Offset: 0x00001D54
//    internal void method_2(int int_0)
//    {
//        uint num = 1U << int_0;
//        this.class2_0.method_0(num);
//        this.class2_1.method_0(num);
//        this.uint_2 = num - 1U;
//    }

//    // Token: 0x06000017 RID: 23 RVA: 0x00003B8C File Offset: 0x00001D8C
//    internal void method_3(Stream stream_0, Stream stream_1)
//    {
//        this.class0_0.method_0(stream_0);
//        this.class4_0.method_1(stream_1, this.bool_0);
//        for (uint num = 0U; num < 12U; num += 1U)
//        {
//            for (uint num2 = 0U; num2 <= this.uint_2; num2 += 1U)
//            {
//                uint num3 = (num << 4) + num2;
//                this.struct0_0[(int)num3].method_0();
//                this.struct0_1[(int)num3].method_0();
//            }
//            this.struct0_2[(int)num].method_0();
//            this.struct0_3[(int)num].method_0();
//            this.struct0_4[(int)num].method_0();
//            this.struct0_5[(int)num].method_0();
//        }
//        this.class3_0.method_1();
//        for (uint num = 0U; num < 4U; num += 1U)
//        {
//            this.struct1_0[(int)num].method_0();
//        }
//        for (uint num = 0U; num < 114U; num += 1U)
//        {
//            this.struct0_6[(int)num].method_0();
//        }
//        this.class2_0.method_1();
//        this.class2_1.method_1();
//        this.struct1_1.method_0();
//    }

//    // Token: 0x06000018 RID: 24 RVA: 0x00003CB0 File Offset: 0x00001EB0
//    internal void method_4(Stream stream_0, Stream stream_1, long long_0, long long_1)
//    {
//        this.method_3(stream_0, stream_1);

//            < Module >.Struct3 @struct = default(< Module >.Struct3);
//        @struct.method_0();
//        uint num = 0U;
//        uint num2 = 0U;
//        uint num3 = 0U;
//        uint num4 = 0U;
//        ulong num5 = 0UL;
//        if (0L < long_1)
//        {
//            this.struct0_0[(int)((int)@struct.uint_0 << 4)].method_1(this.class0_0);
//            @struct.method_1();
//            byte byte_ = this.class3_0.method_3(this.class0_0, 0U, 0);
//            this.class4_0.method_5(byte_);
//            num5 += 1UL;
//        }
//        while (num5 < (ulong)long_1)
//        {
//            uint num6 = (uint)num5 & this.uint_2;
//            if (this.struct0_0[(int)((@struct.uint_0 << 4) + num6)].method_1(this.class0_0) == 0U)
//            {
//                byte byte_2 = this.class4_0.method_6(0U);
//                byte byte_3;
//                if (!@struct.method_5())
//                {
//                    byte_3 = this.class3_0.method_4(this.class0_0, (uint)num5, byte_2, this.class4_0.method_6(num));
//                }
//                else
//                {
//                    byte_3 = this.class3_0.method_3(this.class0_0, (uint)num5, byte_2);
//                }
//                this.class4_0.method_5(byte_3);
//                @struct.method_1();
//                num5 += 1UL;
//            }
//            else
//            {
//                uint num8;
//                if (this.struct0_2[(int)@struct.uint_0].method_1(this.class0_0) == 1U)
//                {
//                    if (this.struct0_3[(int)@struct.uint_0].method_1(this.class0_0) == 0U)
//                    {
//                        if (this.struct0_1[(int)((@struct.uint_0 << 4) + num6)].method_1(this.class0_0) == 0U)
//                        {
//                            @struct.method_4();
//                            this.class4_0.method_5(this.class4_0.method_6(num));
//                            num5 += 1UL;
//                            continue;
//                        }
//                    }
//                    else
//                    {
//                        uint num7;
//                        if (this.struct0_4[(int)@struct.uint_0].method_1(this.class0_0) == 0U)
//                        {
//                            num7 = num2;
//                        }
//                        else
//                        {
//                            if (this.struct0_5[(int)@struct.uint_0].method_1(this.class0_0) == 0U)
//                            {
//                                num7 = num3;
//                            }
//                            else
//                            {
//                                num7 = num4;
//                                num4 = num3;
//                            }
//                            num3 = num2;
//                        }
//                        num2 = num;
//                        num = num7;
//                    }
//                    num8 = this.class2_1.method_2(this.class0_0, num6) + 2U;
//                    @struct.method_3();
//                }
//                else
//                {
//                    num4 = num3;
//                    num3 = num2;
//                    num2 = num;
//                    num8 = 2U + this.class2_0.method_2(this.class0_0, num6);
//                    @struct.method_2();
//                    uint num9 = this.struct1_0[(int)< Module >.Class1.smethod_0(num8)].method_1(this.class0_0);
//                    if (num9 >= 4U)
//                    {
//                        int num10 = (int)((num9 >> 1) - 1U);
//                        num = (2U | (num9 & 1U)) << num10;
//                        if (num9 < 14U)
//                        {
//                            num += < Module >.Struct1.smethod_0(this.struct0_6, num - num9 - 1U, this.class0_0, num10);
//                        }
//                        else
//                        {
//                            num += this.class0_0.method_3(num10 - 4) << 4;
//                            num += this.struct1_1.method_2(this.class0_0);
//                        }
//                    }
//                    else
//                    {
//                        num = num9;
//                    }
//                }
//                if (((ulong)num >= num5 || num >= this.uint_1) && num == 4294967295U)
//                {
//                    break;
//                }
//                this.class4_0.method_4(num, num8);
//                num5 += (ulong)num8;
//            }
//        }
//        this.class4_0.method_3();
//        this.class4_0.method_2();
//        this.class0_0.method_1();
//    }

//    // Token: 0x06000019 RID: 25 RVA: 0x00004014 File Offset: 0x00002214
//    internal void method_5(byte[] byte_0)
//    {
//        int int_ = (int)(byte_0[0] % 9);
//        byte b = byte_0[0] / 9;
//        int int_2 = (int)(b % 5);
//        int int_3 = (int)(b / 5);
//        uint num = 0U;
//        for (int i = 0; i < 4; i++)
//        {
//            num += (uint)((uint)byte_0[1 + i] << i * 8);
//        }
//        this.method_0(num);
//        this.method_1(int_2, int_);
//        this.method_2(int_3);
//    }

//    // Token: 0x0600001A RID: 26 RVA: 0x0000230F File Offset: 0x0000050F
//    internal static uint smethod_0(uint uint_3)
//    {
//        uint_3 -= 2U;
//        if (uint_3 < 4U)
//        {
//            return uint_3;
//        }
//        return 3U;
//    }

//    // Token: 0x04000009 RID: 9
//    internal readonly <Module>.Struct0[] struct0_0 = new < Module >.Struct0[192];

//    // Token: 0x0400000A RID: 10
//    internal readonly <Module>.Struct0[] struct0_1 = new < Module >.Struct0[192];

//    // Token: 0x0400000B RID: 11
//    internal readonly <Module>.Struct0[] struct0_2 = new < Module >.Struct0[12];

//    // Token: 0x0400000C RID: 12
//    internal readonly <Module>.Struct0[] struct0_3 = new < Module >.Struct0[12];

//    // Token: 0x0400000D RID: 13
//    internal readonly <Module>.Struct0[] struct0_4 = new < Module >.Struct0[12];

//    // Token: 0x0400000E RID: 14
//    internal readonly <Module>.Struct0[] struct0_5 = new < Module >.Struct0[12];

//    // Token: 0x0400000F RID: 15
//    internal readonly <Module>.Class1.Class2 class2_0 = new < Module >.Class1.Class2();

//    // Token: 0x04000010 RID: 16
//    internal readonly <Module>.Class1.Class3 class3_0 = new < Module >.Class1.Class3();

//    // Token: 0x04000011 RID: 17
//    internal readonly <Module>.Class4 class4_0 = new < Module >.Class4();

//    // Token: 0x04000012 RID: 18
//    internal readonly <Module>.Struct0[] struct0_6 = new < Module >.Struct0[114];

//    // Token: 0x04000013 RID: 19
//    internal readonly <Module>.Struct1[] struct1_0 = new < Module >.Struct1[4];

//    // Token: 0x04000014 RID: 20
//    internal readonly <Module>.Class0 class0_0 = new < Module >.Class0();

//    // Token: 0x04000015 RID: 21
//    internal readonly <Module>.Class1.Class2 class2_1 = new < Module >.Class1.Class2();

//    // Token: 0x04000016 RID: 22
//    internal bool bool_0;

//    // Token: 0x04000017 RID: 23
//    internal uint uint_0;

//    // Token: 0x04000018 RID: 24
//    internal uint uint_1;

//    // Token: 0x04000019 RID: 25
//    internal <Module>.Struct1 struct1_1 = new < Module >.Struct1(4);

//    // Token: 0x0400001A RID: 26
//    internal uint uint_2;

//    // Token: 0x02000006 RID: 6
//    internal class Class2
//    {
//        // Token: 0x0600001B RID: 27 RVA: 0x00004070 File Offset: 0x00002270
//        internal void method_0(uint uint_1)
//        {
//            for (uint num = this.uint_0; num < uint_1; num += 1U)
//            {
//                this.struct1_0[(int)num] = new < Module >.Struct1(3);
//                this.struct1_1[(int)num] = new < Module >.Struct1(3);
//            }
//            this.uint_0 = uint_1;
//        }

//        // Token: 0x0600001C RID: 28 RVA: 0x000040BC File Offset: 0x000022BC
//        internal void method_1()
//        {
//            this.struct0_0.method_0();
//            for (uint num = 0U; num < this.uint_0; num += 1U)
//            {
//                this.struct1_0[(int)num].method_0();
//                this.struct1_1[(int)num].method_0();
//            }
//            this.struct0_1.method_0();
//            this.struct1_2.method_0();
//        }

//        // Token: 0x0600001D RID: 29 RVA: 0x00004120 File Offset: 0x00002320
//        internal uint method_2(<Module>.Class0 class0_0, uint uint_1)
//        {
//            if (this.struct0_0.method_1(class0_0) == 0U)
//            {
//                return this.struct1_0[(int)uint_1].method_1(class0_0);
//            }
//            uint num = 8U;
//            if (this.struct0_1.method_1(class0_0) == 0U)
//            {
//                num += this.struct1_1[(int)uint_1].method_1(class0_0);
//            }
//            else
//            {
//                num += 8U;
//                num += this.struct1_2.method_1(class0_0);
//            }
//            return num;
//        }

//        // Token: 0x0600001E RID: 30 RVA: 0x0000231D File Offset: 0x0000051D
//        internal Class2()
//        {
//        }

//        // Token: 0x0400001B RID: 27
//        internal readonly <Module>.Struct1[] struct1_0 = new < Module >.Struct1[16];

//        // Token: 0x0400001C RID: 28
//        internal readonly <Module>.Struct1[] struct1_1 = new < Module >.Struct1[16];

//        // Token: 0x0400001D RID: 29
//        internal <Module>.Struct0 struct0_0;

//        // Token: 0x0400001E RID: 30
//        internal <Module>.Struct0 struct0_1;

//        // Token: 0x0400001F RID: 31
//        internal <Module>.Struct1 struct1_2 = new < Module >.Struct1(8);

//        // Token: 0x04000020 RID: 32
//        internal uint uint_0;
//    }

//    // Token: 0x02000007 RID: 7
//    internal class Class3
//    {
//        // Token: 0x0600001F RID: 31 RVA: 0x0000418C File Offset: 0x0000238C
//        internal void method_0(int int_2, int int_3)
//        {
//            if (this.struct2_0 != null && this.int_1 == int_3 && this.int_0 == int_2)
//            {
//                return;
//            }
//            this.int_0 = int_2;
//            this.uint_0 = (1U << int_2) - 1U;
//            this.int_1 = int_3;
//            uint num = 1U << this.int_1 + this.int_0;
//            this.struct2_0 = new < Module >.Class1.Class3.Struct2[num];
//            for (uint num2 = 0U; num2 < num; num2 += 1U)
//            {
//                this.struct2_0[(int)num2].method_0();
//            }
//        }

//        // Token: 0x06000020 RID: 32 RVA: 0x0000420C File Offset: 0x0000240C
//        internal void method_1()
//        {
//            uint num = 1U << this.int_1 + this.int_0;
//            for (uint num2 = 0U; num2 < num; num2 += 1U)
//            {
//                this.struct2_0[(int)num2].method_1();
//            }
//        }

//        // Token: 0x06000021 RID: 33 RVA: 0x0000234B File Offset: 0x0000054B
//        internal uint method_2(uint uint_1, byte byte_0)
//        {
//            return ((uint_1 & this.uint_0) << this.int_1) + (uint)(byte_0 >> 8 - this.int_1);
//        }

//        // Token: 0x06000022 RID: 34 RVA: 0x0000236D File Offset: 0x0000056D
//        internal byte method_3(<Module>.Class0 class0_0, uint uint_1, byte byte_0)
//        {
//            return this.struct2_0[(int)this.method_2(uint_1, byte_0)].method_2(class0_0);
//        }

//        // Token: 0x06000023 RID: 35 RVA: 0x00002388 File Offset: 0x00000588
//        internal byte method_4(<Module>.Class0 class0_0, uint uint_1, byte byte_0, byte byte_1)
//        {
//            return this.struct2_0[(int)this.method_2(uint_1, byte_0)].method_3(class0_0, byte_1);
//        }

//        // Token: 0x06000024 RID: 36 RVA: 0x000022F8 File Offset: 0x000004F8
//        internal Class3()
//        {
//        }

//        // Token: 0x04000021 RID: 33
//        internal <Module>.Class1.Class3.Struct2[] struct2_0;

//        // Token: 0x04000022 RID: 34
//        internal int int_0;

//        // Token: 0x04000023 RID: 35
//        internal int int_1;

//        // Token: 0x04000024 RID: 36
//        internal uint uint_0;

//        // Token: 0x02000008 RID: 8
//        internal struct Struct2
//        {
//            // Token: 0x06000025 RID: 37 RVA: 0x000023A5 File Offset: 0x000005A5
//            internal void method_0()
//            {
//                this.struct0_0 = new < Module >.Struct0[768];
//            }

//            // Token: 0x06000026 RID: 38 RVA: 0x0000424C File Offset: 0x0000244C
//            internal void method_1()
//            {
//                for (int i = 0; i < 768; i++)
//                {
//                    this.struct0_0[i].method_0();
//                }
//            }

//            // Token: 0x06000027 RID: 39 RVA: 0x0000427C File Offset: 0x0000247C
//            internal byte method_2(<Module>.Class0 class0_0)
//            {
//                uint num = 1U;
//                do
//                {
//                    num = (num << 1 | this.struct0_0[(int)num].method_1(class0_0));
//                }
//                while (num < 256U);
//                return (byte)num;
//            }

//            // Token: 0x06000028 RID: 40 RVA: 0x000042AC File Offset: 0x000024AC
//            internal byte method_3(<Module>.Class0 class0_0, byte byte_0)
//            {
//                uint num = 1U;
//                for (; ; )
//                {
//                    uint num2 = (uint)(byte_0 >> 7 & 1);
//                    byte_0 = (byte)(byte_0 << 1);
//                    uint num3 = this.struct0_0[(int)((1U + num2 << 8) + num)].method_1(class0_0);
//                    num = (num << 1 | num3);
//                    if (num2 != num3)
//                    {
//                        break;
//                    }
//                    if (num >= 256U)
//                    {
//                        goto IL_5C;
//                    }
//                }
//                while (num < 256U)
//                {
//                    num = (num << 1 | this.struct0_0[(int)num].method_1(class0_0));
//                }
//            IL_5C:
//                return (byte)num;
//            }

//            // Token: 0x04000025 RID: 37
//            internal <Module>.Struct0[] struct0_0;
//        }
//    }
//}

//// Token: 0x02000009 RID: 9
//internal class Class4
//{
//    // Token: 0x06000029 RID: 41 RVA: 0x000023B7 File Offset: 0x000005B7
//    internal void method_0(uint uint_3)
//    {
//        if (this.uint_2 != uint_3)
//        {
//            this.byte_0 = new byte[uint_3];
//        }
//        this.uint_2 = uint_3;
//        this.uint_0 = 0U;
//        this.uint_1 = 0U;
//    }

//    // Token: 0x0600002A RID: 42 RVA: 0x000023E3 File Offset: 0x000005E3
//    internal void method_1(Stream stream_1, bool bool_0)
//    {
//        this.method_2();
//        this.stream_0 = stream_1;
//        if (!bool_0)
//        {
//            this.uint_1 = 0U;
//            this.uint_0 = 0U;
//        }
//    }

//    // Token: 0x0600002B RID: 43 RVA: 0x00002403 File Offset: 0x00000603
//    internal void method_2()
//    {
//        this.method_3();
//        this.stream_0 = null;
//        Buffer.BlockCopy(new byte[this.byte_0.Length], 0, this.byte_0, 0, this.byte_0.Length);
//    }

//    // Token: 0x0600002C RID: 44 RVA: 0x00004318 File Offset: 0x00002518
//    internal void method_3()
//    {
//        uint num = this.uint_0 - this.uint_1;
//        if (num == 0U)
//        {
//            return;
//        }
//        this.stream_0.Write(this.byte_0, (int)this.uint_1, (int)num);
//        if (this.uint_0 >= this.uint_2)
//        {
//            this.uint_0 = 0U;
//        }
//        this.uint_1 = this.uint_0;
//    }

//    // Token: 0x0600002D RID: 45 RVA: 0x00004370 File Offset: 0x00002570
//    internal void method_4(uint uint_3, uint uint_4)
//    {
//        uint num = this.uint_0 - uint_3 - 1U;
//        if (num >= this.uint_2)
//        {
//            num += this.uint_2;
//        }
//        while (uint_4 > 0U)
//        {
//            if (num >= this.uint_2)
//            {
//                num = 0U;
//            }
//            byte[] array = this.byte_0;
//            uint num2 = this.uint_0;
//            this.uint_0 = num2 + 1U;
//            array[(int)num2] = this.byte_0[(int)num++];
//            if (this.uint_0 >= this.uint_2)
//            {
//                this.method_3();
//            }
//            uint_4 -= 1U;
//        }
//    }

//    // Token: 0x0600002E RID: 46 RVA: 0x000043E8 File Offset: 0x000025E8
//    internal void method_5(byte byte_1)
//    {
//        byte[] array = this.byte_0;
//        uint num = this.uint_0;
//        this.uint_0 = num + 1U;
//        array[(int)num] = byte_1;
//        if (this.uint_0 >= this.uint_2)
//        {
//            this.method_3();
//        }
//    }

//    // Token: 0x0600002F RID: 47 RVA: 0x00004424 File Offset: 0x00002624
//    internal byte method_6(uint uint_3)
//    {
//        uint num = this.uint_0 - uint_3 - 1U;
//        if (num >= this.uint_2)
//        {
//            num += this.uint_2;
//        }
//        return this.byte_0[(int)num];
//    }

//    // Token: 0x06000030 RID: 48 RVA: 0x000022F8 File Offset: 0x000004F8
//    internal Class4()
//    {
//    }

//    // Token: 0x04000026 RID: 38
//    internal byte[] byte_0;

//    // Token: 0x04000027 RID: 39
//    internal uint uint_0;

//    // Token: 0x04000028 RID: 40
//    internal Stream stream_0;

//    // Token: 0x04000029 RID: 41
//    internal uint uint_1;

//    // Token: 0x0400002A RID: 42
//    internal uint uint_2;
//}

//// Token: 0x0200000A RID: 10
//internal struct Struct3
//{
//    // Token: 0x06000031 RID: 49 RVA: 0x00002434 File Offset: 0x00000634
//    internal void method_0()
//    {
//        this.uint_0 = 0U;
//    }

//    // Token: 0x06000032 RID: 50 RVA: 0x0000243D File Offset: 0x0000063D
//    internal void method_1()
//    {
//        if (this.uint_0 < 4U)
//        {
//            this.uint_0 = 0U;
//            return;
//        }
//        if (this.uint_0 < 10U)
//        {
//            this.uint_0 -= 3U;
//            return;
//        }
//        this.uint_0 -= 6U;
//    }

//    // Token: 0x06000033 RID: 51 RVA: 0x00002477 File Offset: 0x00000677
//    internal void method_2()
//    {
//        this.uint_0 = ((this.uint_0 < 7U) ? 7U : 10U);
//    }

//    // Token: 0x06000034 RID: 52 RVA: 0x0000248D File Offset: 0x0000068D
//    internal void method_3()
//    {
//        this.uint_0 = ((this.uint_0 < 7U) ? 8U : 11U);
//    }

//    // Token: 0x06000035 RID: 53 RVA: 0x000024A3 File Offset: 0x000006A3
//    internal void method_4()
//    {
//        this.uint_0 = ((this.uint_0 < 7U) ? 9U : 11U);
//    }

//    // Token: 0x06000036 RID: 54 RVA: 0x000024BA File Offset: 0x000006BA
//    internal bool method_5()
//    {
//        return this.uint_0 < 7U;
//    }

//    // Token: 0x0400002B RID: 43
//    internal uint uint_0;
//}

//// Token: 0x0200000B RID: 11
//[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 384)]
//internal struct Struct4
//{
//}
//}
