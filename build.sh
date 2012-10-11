/Applications/MonoDevelop.app/Contents/MacOS/mdtool build
nunit-console BingoCoreTest/bin/Debug/BingoCoreTest.dll
java -jar mtouch_adapter.jar
cd Bingo4iPhone
export DYLD_INSERT_LIBRARIES=;
cucumber
