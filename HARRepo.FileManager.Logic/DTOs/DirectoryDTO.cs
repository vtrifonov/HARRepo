﻿using System;
using System.Collections.Generic;
using System.Text;

namespace HARRepo.FileManager.Logic.DTOs
{
    public class DirectoryDTO : BaseDTO
    {
        public string Name { get; set; }

        public List<DirectoryDTO> SubDirectories { get; set; }

        public List<FileDTO> Files { get; set; }
    }
}
