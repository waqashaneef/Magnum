﻿// Copyright 2007-2008 The Apache Software Foundation.
//  
// Licensed under the Apache License, Version 2.0 (the "License"); you may not use 
// this file except in compliance with the License. You may obtain a copy of the 
// License at 
// 
//     http://www.apache.org/licenses/LICENSE-2.0 
// 
// Unless required by applicable law or agreed to in writing, software distributed 
// under the License is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR 
// CONDITIONS OF ANY KIND, either express or implied. See the License for the 
// specific language governing permissions and limitations under the License.
namespace Magnum.Channels
{
	using Configuration;


	public static class ExtensionsForConsumerChannel
	{
		/// <summary>
		/// Consumes the message on a ConsumerChannel, given the specified delegate
		/// </summary>
		/// <param name="configurator"></param>
		/// <param name="consumer"></param>
		/// <returns></returns>
		public static ConsumerChannelConfigurator<TChannel> UsingConsumer<TChannel>(
			this ChannelConnectionConfigurator<TChannel> configurator, Consumer<TChannel> consumer)
		{
			var consumerConfigurator = new ConsumerChannelConfiguratorImpl<TChannel>(consumer);

			configurator.SetChannelFactory(consumerConfigurator);

			return consumerConfigurator;
		}
	}
}