using Microsoft.AspNetCore.Http;

namespace LogicalCohesion;

public class FileService
{
    public async Task SaveFileAsync(string fileName, IFormFile file, string filePath)
    {
        string filepath = Path.Combine(filePath, fileName);
        using (var stream = new FileStream(filepath, FileMode.Create))
        {
            file.CopyTo(stream);
        }
    }
    public async Task DeleteFilesAsync(string fileName, string filePath)
    {
        string[] filesToDelete = Directory.GetFiles(filePath, fileName + ".*");
        foreach (var file in filesToDelete)
        {
            File.Delete(file);
        }
    }

    public string GenerateUniqueFileName(string imageName)
    {
        Random random = new Random();
        int randomNumber = random.Next(1000, 9999);
        string timestamp = DateTime.Now.ToString("yyyyMMddHHmmssfff");

        string uniqueFileName = $"{imageName}-{timestamp}-{randomNumber}.txt";
        return uniqueFileName;
    }

    public List<string> GetImageFilesByPrefix(string filePath, string startString)
    {
        List<string> results = new List<string>();
        string[] fileExtensions = { ".jpg", ".png", ".jpeg" };

        if (Directory.Exists(filePath))
        {
            foreach (var file in Directory.EnumerateFiles(filePath))
            {
                FileInfo fileInfo = new FileInfo(file);

                if (fileExtensions.Contains(fileInfo.Extension.ToLower()) && fileInfo.Name.StartsWith(startString))
                {
                    results.Add(fileInfo.Name);
                }
            }
        }

        return results;
    }

    public async Task DeleteAllFilesByPrefix(string filePath, string startString)
    {
        string[] fileExtensions = { ".jpg", ".png", ".jpeg" };
        if (Directory.Exists(filePath))
        {
            foreach (var file in Directory.EnumerateFiles(filePath))
            {
                FileInfo fileInfo = new FileInfo(file);

                if (fileExtensions.Contains(fileInfo.Extension.ToLower()) && fileInfo.Name.StartsWith(startString))
                {
                    File.Delete(fileInfo.FullName);
                }
            }
        }
    }
}
