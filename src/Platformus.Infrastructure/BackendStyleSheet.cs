﻿// Copyright © 2015 Dmitry Sikorsky. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

namespace Platformus.Infrastructure
{
  public class BackendStyleSheet
  {
    public string Url { get; set; }
    public int Position { get; set; }

    public BackendStyleSheet(string url, int position)
    {
      this.Url = url;
      this.Position = position;
    }
  }
}