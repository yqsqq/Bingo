rm -fr Bingo4iPhone/bin/iPhoneSimulator/*
rm -fr BingoCore/bin/*
rm -fr BingoCoreTest/bin/*
rm -fr Test/bin/iPhoneSimulator/*

/Applications/MonoDevelop.app/Contents/MacOS/mdtool build
nunit-console BingoCoreTest/bin/Debug/BingoCoreTest.dll
java -jar mtouch_adapter.jar
