call "C:\Program Files (x86)\Microsoft Visual Studio\2019\Professional\Common7\Tools\VsDevCmd.bat"

git clean -xdf

msbuild CppLibrary\CppLibrary.vcxproj
msbuild CppTest.sln
