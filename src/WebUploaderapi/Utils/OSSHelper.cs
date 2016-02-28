using Microsoft.AspNet.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Aliyun.OSS;
using System.IO;
using Aliyun.OSS.Util;

namespace WebUploaderapi.Utils
{
    public class OSSHelper
    {
        public static string accessKeyId = "2s0GVl7X3BZ3bdkC";
        public static string accessKeySecret = "8exMuwi3AkUhSn7ZJDAUWTwZ0T3rvD";
        public static string endpoint = "http://qibucloud.oss-cn-hangzhou.aliyuncs.com";

        static OssClient ossClient = new OssClient(endpoint, accessKeyId, accessKeySecret);

        public static bool Upload(string bucketName, string fileName, string fileToUpload)
        {
            bool success = false;
            try
            {
                if (!DoesBucketExist(bucketName))
                {
                    if (!CreateBucket(bucketName))
                    {
                        return success;
                    }
                }

                string eTag;
                using (var fs = File.Open(fileToUpload, FileMode.Open))
                {
                    eTag = OssUtils.ComputeContentMd5(fs, fs.Length);
                }

                var objectMeta = new ObjectMetadata { ETag = eTag };
                var result = ossClient.PutObject(bucketName, fileName, fileToUpload, objectMeta);
                success = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Put object failed, {0}", ex.Message);
            }
            return success;
        }

        /// <summary>
        /// 创建一个新的存储空间（Bucket）
        /// </summary>
        /// <param name="bucketName">存储空间的名称</param>
        public static bool CreateBucket(string bucketName)
        {
            bool success = false;
            try
            {
                // 新建一个Bucket
                ossClient.CreateBucket(bucketName);
                success = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Create bucket failed. {0}", ex.Message);
            }
            return success;
        }

        /// <summary>
        /// 判断存储空间是否存在
        /// </summary>
        /// <param name="bucketName">存储空间的名称</param>
        public static bool DoesBucketExist(string bucketName)
        {
            bool exist = false;
            try
            {
                exist = ossClient.DoesBucketExist(bucketName);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Check object Exist failed. {0}", ex.Message);
            }
            return exist;
        }
    }
}