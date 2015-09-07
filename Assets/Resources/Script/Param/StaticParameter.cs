using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public static class StaticParameter{

	public static string database;
	public static string databaseUsed;
	public static bool isNewProject;
	public static int countNewProject;
	public static List<string> namesNewProject;
	public static List<string> namesDatabaseUsed;
}

public static class UsedTable{

	public static List<string> items;
	public static List<string> sqlTables;

	public static void Init(){
		items = new List<string>();
		sqlTables = new List<string>();
	}

	public static void Clear(){
		items.Clear();
		sqlTables.Clear();
		items=null;
		sqlTables=null;
	}
}

public class SQLTable{
	public string name;
	public List<string> items;
	public List<bool> keys;
}