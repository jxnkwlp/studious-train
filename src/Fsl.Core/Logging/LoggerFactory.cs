﻿using Fsl.Abstractions.Logging;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fsl.Logging
{
	public class LoggerFactory : ILoggerFactory
	{
		public void AddProvider(ILoggerProvider provider)
		{
			throw new NotImplementedException();
		}

		public ILogger CreateLogger(string categoryName)
		{
			throw new NotImplementedException();
		}

		public void Dispose()
		{
			throw new NotImplementedException();
		}
	}
}