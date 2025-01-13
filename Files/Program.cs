﻿
// The directory we want to enumerate and results file name.
const string folder = "FileCollection";
const string resultfile = "result.txt";

// Variables to hold the results.
long XLSCount = 0, DOCCount = 0, PPTCount = 0;
long XLSSize = 0, DOCSize = 0, PPTSize = 0;
long totalfiles = 0;
long totalsize = 0;

bool IsOfficeFile(string filename) {
    // if the file ends with a known office suffix, return true.
    if (filename.EndsWith(".xlsx") || filename.EndsWith(".docx") || filename.EndsWith(".pptx")) {
        return true;
    }

    return false;
}

if (!Directory.Exists(folder)) {
    Directory.CreateDirectory(folder);
}

// create a DirectoryInfo for the given folder.
DirectoryInfo di = new DirectoryInfo(folder);

foreach (FileInfo fi in di.EnumerateFiles()) {
    if (IsOfficeFile(fi.Name)) {
        totalfiles++;
        totalsize += fi.Length;
        if (fi.Name.EndsWith(".xlsx")) {
            XLSCount++;
            XLSSize += fi.Length;
        }

        if (fi.Name.EndsWith(".docx")) {
            DOCCount++;
            DOCSize += fi.Length;
        }

        if (fi.Name.EndsWith(".pptx")) {
            PPTCount++;
            PPTSize += fi.Length;
        }
    }
}

using (StreamWriter sw = File.CreateText(resultfile)) {
    sw.WriteLine("~~~~ Results ~~~~");
    sw.WriteLine($"Total Files: {totalfiles}");
    sw.WriteLine($"Excel Count: {XLSCount}");
    sw.WriteLine($"Word Count: {DOCCount}");
    sw.WriteLine($"PowerPoint Count: {PPTCount}");
    sw.WriteLine("----");
    sw.WriteLine($"Total Size: {totalsize}");
    sw.WriteLine($"Excel Size: {XLSSize}");
    sw.WriteLine($"Word Size: {DOCSize}");
    sw.WriteLine($"PowerPoint Size: {PPTSize}");

}
