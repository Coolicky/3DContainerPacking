﻿using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coolicky.TrailerPacking.Entities;

public class ContainerPackingResult
{
	public int ContainerID { get; set; }
	public List<AlgorithmPackingResult> AlgorithmPackingResults { get; set; } = [];

}