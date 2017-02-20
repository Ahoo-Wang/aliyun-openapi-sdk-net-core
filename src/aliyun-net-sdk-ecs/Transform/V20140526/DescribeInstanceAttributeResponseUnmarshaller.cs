/*
 * Licensed to the Apache Software Foundation (ASF) under one
 * or more contributor license agreements.  See the NOTICE file
 * distributed with this work for additional information
 * regarding copyright ownership.  The ASF licenses this file
 * to you under the Apache License, Version 2.0 (the
 * "License"); you may not use this file except in compliance
 * with the License.  You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Ecs.Model.V20140526;
using System.Collections.Generic;

namespace Aliyun.Acs.Ecs.Transform.V20140526
{
    public class DescribeInstanceAttributeResponseUnmarshaller
    {
        public static DescribeInstanceAttributeResponse Unmarshall(UnmarshallerContext context)
        {
            DescribeInstanceAttributeResponse describeInstanceAttributeResponse = new DescribeInstanceAttributeResponse()
            {
                HttpResponse = context.HttpResponse,
                RequestId = context.StringValue("DescribeInstanceAttribute.RequestId"),
                InstanceId = context.StringValue("DescribeInstanceAttribute.InstanceId"),
                InstanceName = context.StringValue("DescribeInstanceAttribute.InstanceName"),
                ImageId = context.StringValue("DescribeInstanceAttribute.ImageId"),
                RegionId = context.StringValue("DescribeInstanceAttribute.RegionId"),
                ZoneId = context.StringValue("DescribeInstanceAttribute.ZoneId"),
                ClusterId = context.StringValue("DescribeInstanceAttribute.ClusterId"),
                InstanceType = context.StringValue("DescribeInstanceAttribute.InstanceType"),
                Cpu = context.IntegerValue("DescribeInstanceAttribute.Cpu"),
                Memory = context.IntegerValue("DescribeInstanceAttribute.Memory"),
                HostName = context.StringValue("DescribeInstanceAttribute.HostName"),
                Status = context.EnumValue<DescribeInstanceAttributeResponse.StatusEnum>("DescribeInstanceAttribute.Status"),
                InternetChargeType = context.StringValue("DescribeInstanceAttribute.InternetChargeType"),
                InternetMaxBandwidthIn = context.IntegerValue("DescribeInstanceAttribute.InternetMaxBandwidthIn"),
                InternetMaxBandwidthOut = context.IntegerValue("DescribeInstanceAttribute.InternetMaxBandwidthOut"),
                VlanId = context.StringValue("DescribeInstanceAttribute.VlanId"),
                SerialNumber = context.StringValue("DescribeInstanceAttribute.SerialNumber"),
                CreationTime = context.StringValue("DescribeInstanceAttribute.CreationTime"),
                Description = context.StringValue("DescribeInstanceAttribute.Description"),
                InstanceNetworkType = context.StringValue("DescribeInstanceAttribute.InstanceNetworkType"),
                IoOptimized = context.StringValue("DescribeInstanceAttribute.IoOptimized"),
                InstanceChargeType = context.StringValue("DescribeInstanceAttribute.InstanceChargeType"),
                ExpiredTime = context.StringValue("DescribeInstanceAttribute.ExpiredTime")
            };
            List<string> securityGroupIds = new List<string>();
			for (int i = 0; i < context.Length("DescribeInstanceAttribute.SecurityGroupIds.Length"); i++) {
				securityGroupIds.Add(context.StringValue($"DescribeInstanceAttribute.SecurityGroupIds[{i}]"));
			}
			describeInstanceAttributeResponse.SecurityGroupIds = securityGroupIds;

			List<string> publicIpAddress = new List<string>();
			for (int i = 0; i < context.Length("DescribeInstanceAttribute.PublicIpAddress.Length"); i++) {
				publicIpAddress.Add(context.StringValue($"DescribeInstanceAttribute.PublicIpAddress[{i}]"));
			}
			describeInstanceAttributeResponse.PublicIpAddress = publicIpAddress;

			List<string> innerIpAddress = new List<string>();
			for (int i = 0; i < context.Length("DescribeInstanceAttribute.InnerIpAddress.Length"); i++) {
				innerIpAddress.Add(context.StringValue($"DescribeInstanceAttribute.InnerIpAddress[{i}]"));
			}
			describeInstanceAttributeResponse.InnerIpAddress = innerIpAddress;

            DescribeInstanceAttributeResponse.VpcAttributes_ vpcAttributes = new DescribeInstanceAttributeResponse.VpcAttributes_()
            {
                VpcId = context.StringValue("DescribeInstanceAttribute.VpcAttributes.VpcId"),
                VSwitchId = context.StringValue("DescribeInstanceAttribute.VpcAttributes.VSwitchId"),
                NatIpAddress = context.StringValue("DescribeInstanceAttribute.VpcAttributes.NatIpAddress")
            };
            List<string> privateIpAddress = new List<string>();
			for (int i = 0; i < context.Length("DescribeInstanceAttribute.VpcAttributes.PrivateIpAddress.Length"); i++) {
				privateIpAddress.Add(context.StringValue($"DescribeInstanceAttribute.VpcAttributes.PrivateIpAddress[{i}]"));
			}
			vpcAttributes.PrivateIpAddress = privateIpAddress;
			describeInstanceAttributeResponse.VpcAttributes = vpcAttributes;

            DescribeInstanceAttributeResponse.EipAddress_ eipAddress = new DescribeInstanceAttributeResponse.EipAddress_()
            {
                AllocationId = context.StringValue("DescribeInstanceAttribute.EipAddress.AllocationId"),
                IpAddress = context.StringValue("DescribeInstanceAttribute.EipAddress.IpAddress"),
                Bandwidth = context.IntegerValue("DescribeInstanceAttribute.EipAddress.Bandwidth"),
                InternetChargeType = context.StringValue("DescribeInstanceAttribute.EipAddress.InternetChargeType")
            };
            describeInstanceAttributeResponse.EipAddress = eipAddress;

			List<DescribeInstanceAttributeResponse.LockReason> operationLocks = new List<DescribeInstanceAttributeResponse.LockReason>();
			for (int i = 0; i < context.Length("DescribeInstanceAttribute.OperationLocks.Length"); i++) {
                DescribeInstanceAttributeResponse.LockReason lockReason = new DescribeInstanceAttributeResponse.LockReason()
                {
                    LockReason_ = context.StringValue($"DescribeInstanceAttribute.OperationLocks[{i}].LockReason")
                };
                operationLocks.Add(lockReason);
			}
			describeInstanceAttributeResponse.OperationLocks = operationLocks;
        
			return describeInstanceAttributeResponse;
        }
    }
}