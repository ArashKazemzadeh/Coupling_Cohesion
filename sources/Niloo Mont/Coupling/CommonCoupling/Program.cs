using CommonCoupling;

string filePath = "TestFile.txt";

FileService fileService = new();
fileService.ReadFromFile(filePath);
fileService.WriteToFile(filePath, "Some Added Text");
fileService.ReadFromFile(filePath);
