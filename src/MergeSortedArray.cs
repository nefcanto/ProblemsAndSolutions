﻿using System;

public class MergeSortedArray
{
    public int[] Merge(int[] nums1, int m, int[] nums2, int n)
    {
        for (int i = 0; i < n; i++)
        {
            nums1[m + i] = nums2[i];
        }
        Array.Sort(nums1);
        return nums1;
    }
}