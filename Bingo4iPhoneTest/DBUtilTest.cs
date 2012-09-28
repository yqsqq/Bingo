
using System;
using NUnit.Framework;
using Bingo4iPhone;

namespace Bingo4iPhoneTest
{
	[TestFixture]
	public class DBUtilTest
	{
		[Test]
		public void testLoadConfiguration ()
		{
			string conf=DBUtil.loadConfiguration();
			Assert.IsNotNull(conf);
			Assert.That(conf.Length>0);
		}
	}
}
