using LogicalCohesion;

string filePath = @"D:\"; 

FileService fileService = new FileService();

string fileName = fileService.GenerateUniqueFileName("example");
string fullPath = Path.Combine(filePath, fileName);

File.WriteAllText(fullPath, "This is a sample content.");
Console.WriteLine("File saved successfully.");

string startString = "example";
List<string> filesToDelete = fileService.GetImageFilesByPrefix(filePath, startString);
if (filesToDelete.Any())
{
    Console.WriteLine("Files found for deletion:");
    foreach (var file in filesToDelete)
    {
        Console.WriteLine(file);
    }
    await fileService.DeleteFilesAsync(startString, filePath);
    Console.WriteLine("Files deleted successfully.");
}
else
{
    Console.WriteLine("No files found for deletion.");
}
await fileService.DeleteAllFilesByPrefix(filePath, startString);
Console.WriteLine("All files with the specified prefix deleted.");

Console.ReadKey();