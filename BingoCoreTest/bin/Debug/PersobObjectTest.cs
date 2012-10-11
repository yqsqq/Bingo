using System;
using NUnit.Framework;
using BingoCore;

namespace BingoCoreTest
{
	[TestFixture()]
	public class PersobObjectTest
	{
		[Test()]
		public void TestGetRoles ()
		{
			PersonObject person=new PersonObject();
			string role=person.getRole();
			Assert.IsNotNull(role);
			Assert.That(role.Length>0);
		}
	}
}

