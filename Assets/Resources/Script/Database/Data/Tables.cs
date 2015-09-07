using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public static class SQLTables{
	public static List<SQLTable> dTables;
	
	public static void InitMahasiswa(){
		dTables = new List<SQLTable>();
		dTables.Clear();
		List<string> tempItems1 = new List<string>();
		List<string> tempItems2 = new List<string>();
		List<string> tempItems3 = new List<string>();
		List<bool> tempKeys1 = new List<bool>();
		List<bool> tempKeys2 = new List<bool>();
		List<bool> tempKeys3 = new List<bool>();
		SQLTable tempTable1 = new SQLTable();
		SQLTable tempTable2 = new SQLTable();
		SQLTable tempTable3 = new SQLTable();
		//kuliah
		tempItems1.Add("Kuliah");
		tempItems1.Add("Kode");
		tempItems1.Add("Tingkat");
		tempItems1.Add("Kelas");
		tempItems1.Add("Pengajar");
		tempItems1.Add("Bagian");
		tempItems1.Add("Lama");
		tempItems1.Add("Mahasiswa");
		tempTable1.items = tempItems1;
		tempKeys1.Add(true);
		tempKeys1.Add(false);
		tempKeys1.Add(false);
		tempKeys1.Add(true);
		tempKeys1.Add(false);
		tempKeys1.Add(false);
		tempKeys1.Add(false);
		tempTable1.keys = tempKeys1;
		dTables.Add(tempTable1);
		//Tempat
		tempItems2.Add("Tempat");
		tempItems2.Add("Ruangan");
		tempItems2.Add("Kapasitas");
		tempTable2.items = tempItems2;
		tempKeys2.Add(true);
		tempKeys2.Add(false);
		tempTable2.keys = tempKeys2;
		dTables.Add(tempTable2);
		//Waktu
		tempItems3.Add("Waktu");
		tempItems3.Add("Hari");
		tempItems3.Add("Jam1");
		tempItems3.Add("Jam2");
		tempItems3.Add("Keterangan");
		tempItems3.Add("Slot");
		tempTable3.items = tempItems3;
		tempKeys3.Add(false);
		tempKeys3.Add(false);
		tempKeys3.Add(false);
		tempKeys3.Add(false);
		tempKeys3.Add(false);
		tempTable3.keys = tempKeys3;
		dTables.Add(tempTable3);
	}
	
	public static void InitSeminarI(){
		dTables = new List<SQLTable>();
		dTables.Clear();
		List<string> tempItems1 = new List<string>();
		List<string> tempItems2 = new List<string>();
		List<string> tempItems3 = new List<string>();
		List<bool> tempKeys1 = new List<bool>();
		List<bool> tempKeys2 = new List<bool>();
		List<bool> tempKeys3 = new List<bool>();
		SQLTable tempTable1 = new SQLTable();
		SQLTable tempTable2 = new SQLTable();
		SQLTable tempTable3 = new SQLTable();
		//Mahasiswa
		tempItems1.Add("Mahasiswa");
		tempItems1.Add("NIM");
		tempItems1.Add("Nama");
		tempItems1.Add("Judul");
		tempItems1.Add("Bidang");
		tempItems1.Add("Pembimbing1");
		tempItems1.Add("Pembimbing2");
		tempTable1.items = tempItems1;
		tempKeys1.Add(true);
		tempKeys1.Add(false);
		tempKeys1.Add(false);
		tempKeys1.Add(false);
		tempKeys1.Add(true);
		tempKeys1.Add(true);
		tempTable1.keys = tempKeys1;
		dTables.Add(tempTable1);
		//Tempat
		tempItems2.Add("Tempat");
		tempItems2.Add("Ruangan");
		tempTable2.items = tempItems2;
		tempKeys2.Add(true);
		tempTable2.keys = tempKeys2;
		dTables.Add(tempTable2);
		//Waktu
		tempItems3.Add("Waktu");
		tempItems3.Add("Hari");
		tempItems3.Add("Jam");
		tempTable3.items = tempItems3;
		tempKeys3.Add(false);
		tempKeys3.Add(false);
		tempTable3.keys = tempKeys3;
		dTables.Add(tempTable3);
	}
	
	public static void InitSeminarII(){
		dTables = new List<SQLTable>();
		dTables.Clear();
		List<string> tempItems1 = new List<string>();
		List<string> tempItems2 = new List<string>();
		List<string> tempItems3 = new List<string>();
		List<bool> tempKeys1 = new List<bool>();
		List<bool> tempKeys2 = new List<bool>();
		List<bool> tempKeys3 = new List<bool>();
		SQLTable tempTable1 = new SQLTable();
		SQLTable tempTable2 = new SQLTable();
		SQLTable tempTable3 = new SQLTable();
		//kuliah
		tempItems1.Add("Mahasiswa");
		tempItems1.Add("NIM");
		tempItems1.Add("Nama");
		tempItems1.Add("Judul");
		tempItems1.Add("Bidang");
		tempItems1.Add("Pembimbing1");
		tempItems1.Add("Pembimbing2");
		tempTable1.items = tempItems1;
		tempKeys1.Add(true);
		tempKeys1.Add(false);
		tempKeys1.Add(false);
		tempKeys1.Add(false);
		tempKeys1.Add(true);
		tempKeys1.Add(true);
		tempTable1.keys = tempKeys1;
		dTables.Add(tempTable1);
		//Tempat
		tempItems2.Add("Tempat");
		tempItems2.Add("Ruangan");
		tempTable2.items = tempItems2;
		tempKeys2.Add(true);
		tempTable2.keys = tempKeys2;
		dTables.Add(tempTable2);
		//Waktu
		tempItems3.Add("Waktu");
		tempItems3.Add("Hari");
		tempItems3.Add("Jam");
		tempTable3.items = tempItems3;
		tempKeys3.Add(false);
		tempKeys3.Add(false);
		tempTable3.keys = tempKeys3;
		dTables.Add(tempTable3);
	}
	
	public static void InitSidang(){
		dTables = new List<SQLTable>();
		dTables.Clear();
		List<string> tempItems1 = new List<string>();
		List<string> tempItems2 = new List<string>();
		List<string> tempItems3 = new List<string>();
		List<string> tempItems4 = new List<string>();
		List<string> tempItems5 = new List<string>();
		List<bool> tempKeys1 = new List<bool>();
		List<bool> tempKeys2 = new List<bool>();
		List<bool> tempKeys3 = new List<bool>();
		List<bool> tempKeys4 = new List<bool>();
		List<bool> tempKeys5 = new List<bool>();
		SQLTable tempTable1 = new SQLTable();
		SQLTable tempTable2 = new SQLTable();
		SQLTable tempTable3 = new SQLTable();
		SQLTable tempTable4 = new SQLTable();
		SQLTable tempTable5 = new SQLTable();
		//Mahasiswa
		tempItems1.Add("Mahasiswa");
		tempItems1.Add("NIM");
		tempItems1.Add("Nama");
		tempItems1.Add("Judul");
		tempItems1.Add("Bidang");
		tempItems1.Add("Pembimbing1");
		tempItems1.Add("Pembimbing2");
		tempTable1.items = tempItems1;
		tempKeys1.Add(true);
		tempKeys1.Add(false);
		tempKeys1.Add(false);
		tempKeys1.Add(false);
		tempKeys1.Add(true);
		tempKeys1.Add(true);
		tempTable1.keys = tempKeys1;
		dTables.Add(tempTable1);
		//Penguji1
		tempItems2.Add("Penguji1");
		tempItems2.Add("Penguji1");
		tempItems2.Add("Bidang11");
		tempItems2.Add("Bidang12");
		tempTable2.items = tempItems2;
		tempKeys2.Add(true);
		tempKeys2.Add(false);
		tempKeys2.Add(false);
		tempTable2.keys = tempKeys2;
		dTables.Add(tempTable2);
		//Penguji2
		tempItems3.Add("Penguji2");
		tempItems3.Add("Penguji2");
		tempItems3.Add("Bidang21");
		tempItems3.Add("Bidang22");
		tempTable3.items = tempItems3;
		tempKeys3.Add(true);
		tempKeys3.Add(false);
		tempKeys3.Add(false);
		tempTable3.keys = tempKeys3;
		dTables.Add(tempTable3);
		//Tempat
		tempItems4.Add("Tempat");
		tempItems4.Add("Ruangan");
		tempTable4.items = tempItems4;
		tempKeys4.Add(true);
		tempTable4.keys = tempKeys4;
		dTables.Add(tempTable4);
		//Waktu
		tempItems5.Add("Waktu");
		tempItems5.Add("Hari");
		tempItems5.Add("Jam");
		tempTable5.items = tempItems5;
		tempKeys5.Add(false);
		tempKeys5.Add(false);
		tempTable5.keys = tempKeys5;
		dTables.Add(tempTable5);
	}
	
	public static void CheckTables(){
		for(int i=0; i<dTables.Count;i++){
			
		}
	}
	
	public static void InitJadwal(){
		dTables = new List<SQLTable>();
		dTables.Clear();
		List<string> tempItems1 = new List<string>();
		List<string> tempItems2 = new List<string>();
		List<string> tempItems3 = new List<string>();
		List<string> tempItems4 = new List<string>();
		List<bool> tempKeys1 = new List<bool>();
		List<bool> tempKeys2 = new List<bool>();
		List<bool> tempKeys3 = new List<bool>();
		List<bool> tempKeys4 = new List<bool>();
		SQLTable tempTable1 = new SQLTable();
		SQLTable tempTable2 = new SQLTable();
		SQLTable tempTable3 = new SQLTable();
		SQLTable tempTable4 = new SQLTable();
		//Mahasiswa
		tempItems1.Add("Mahasiswa");
		tempItems1.Add("NIM");
		tempItems1.Add("Nama");
		tempItems1.Add("Judul");
		tempItems1.Add("Bidang");
		tempItems1.Add("Pembimbing1");
		tempItems1.Add("Pembimbing2");
		tempTable1.items = tempItems1;
		tempKeys1.Add(true);
		tempKeys1.Add(false);
		tempKeys1.Add(false);
		tempKeys1.Add(false);
		tempKeys1.Add(false);
		tempKeys1.Add(false);
		tempTable1.keys = tempKeys1;
		dTables.Add(tempTable1);
		//Dosen
		tempItems2.Add("Dosen");
		tempItems2.Add("Penguji");
		tempItems2.Add("Bidang1");
		tempItems2.Add("Bidang2");
		tempTable2.items = tempItems2;
		tempKeys2.Add(false);
		tempKeys2.Add(false);
		tempKeys2.Add(false);
		tempTable2.keys = tempKeys2;
		dTables.Add(tempTable2);
		//Tempat
		tempItems3.Add("Tempat");
		tempItems3.Add("Ruangan");
		tempTable3.items = tempItems3;
		tempKeys3.Add(true);
		tempTable3.keys = tempKeys3;
		dTables.Add(tempTable3);
		//Waktu
		tempItems4.Add("Waktu");
		tempItems4.Add("Kode Waktu");
		tempItems4.Add("Hari");
		tempItems4.Add("Jam");
		tempItems4.Add("Hasil");
		tempTable4.items = tempItems4;
		tempKeys4.Add(true);
		tempKeys4.Add(false);
		tempKeys4.Add(false);
		tempKeys4.Add(false);
		tempTable4.keys = tempKeys4;
		dTables.Add(tempTable4);
	}
	
	public static void InitJadwalb(){
		dTables = new List<SQLTable>();
		dTables.Clear();
		List<string> tempItems1 = new List<string>();
		List<string> tempItems2 = new List<string>();
		List<string> tempItems3 = new List<string>();
		List<string> tempItems4 = new List<string>();
		List<bool> tempKeys1 = new List<bool>();
		List<bool> tempKeys2 = new List<bool>();
		List<bool> tempKeys3 = new List<bool>();
		List<bool> tempKeys4 = new List<bool>();
		SQLTable tempTable1 = new SQLTable();
		SQLTable tempTable2 = new SQLTable();
		SQLTable tempTable3 = new SQLTable();
		SQLTable tempTable4 = new SQLTable();
		//Mahasiswa
		tempItems1.Add("Mahasiswa");
		tempItems1.Add("NIM");
		tempItems1.Add("Nama");
		tempItems1.Add("Judul");
		tempItems1.Add("Bidang");
		tempItems1.Add("Pembimbing1");
		tempItems1.Add("Pembimbing2");
		tempTable1.items = tempItems1;
		tempKeys1.Add(true);
		tempKeys1.Add(false);
		tempKeys1.Add(false);
		tempKeys1.Add(false);
		tempKeys1.Add(false);
		tempKeys1.Add(false);
		tempTable1.keys = tempKeys1;
		dTables.Add(tempTable1);
		//Dosen
		tempItems2.Add("Dosen");
		tempItems2.Add("Penguji");
		tempItems2.Add("Bidang1");
		tempItems2.Add("Bidang2");
		tempTable2.items = tempItems2;
		tempKeys2.Add(false);
		tempKeys2.Add(false);
		tempKeys2.Add(false);
		tempTable2.keys = tempKeys2;
		dTables.Add(tempTable2);
		//Tempat
		tempItems3.Add("Tempat");
		tempItems3.Add("Ruangan");
		tempTable3.items = tempItems3;
		tempKeys3.Add(true);
		tempTable3.keys = tempKeys3;
		dTables.Add(tempTable3);
		//Waktu
		tempItems4.Add("Waktu");
		tempItems4.Add("Kode Waktu");
		tempItems4.Add("Hari");
		tempItems4.Add("Jam");
		tempTable4.items = tempItems4;
		tempKeys4.Add(true);
		tempKeys4.Add(false);
		tempKeys4.Add(false);
		tempTable4.keys = tempKeys4;
		dTables.Add(tempTable4);
	}
	
	public static void InitJadwal2(){
		dTables = new List<SQLTable>();
		dTables.Clear();
		List<string> tempItems1 = new List<string>();
		//List<string> tempItems2 = new List<string>();
		List<string> tempItems3 = new List<string>();
		List<string> tempItems4 = new List<string>();
		List<bool> tempKeys1 = new List<bool>();
		//List<bool> tempKeys2 = new List<bool>();
		List<bool> tempKeys3 = new List<bool>();
		List<bool> tempKeys4 = new List<bool>();
		SQLTable tempTable1 = new SQLTable();
		//SQLTable tempTable2 = new SQLTable();
		SQLTable tempTable3 = new SQLTable();
		SQLTable tempTable4 = new SQLTable();
		//Mahasiswa
		tempItems1.Add("Mahasiswa");
		tempItems1.Add("NIM");
		tempItems1.Add("Nama");
		tempItems1.Add("Judul");
		tempItems1.Add("Bidang");
		tempItems1.Add("Pembimbing1");
		tempItems1.Add("Pembimbing2");
		tempTable1.items = tempItems1;
		tempKeys1.Add(true);
		tempKeys1.Add(false);
		tempKeys1.Add(false);
		tempKeys1.Add(false);
		tempKeys1.Add(false);
		tempKeys1.Add(false);
		tempTable1.keys = tempKeys1;
		dTables.Add(tempTable1);
		//Dosen
		//		tempItems2.Add("Dosen");
		//		tempItems2.Add("Penguji");
		//		tempItems2.Add("Bidang1");
		//		tempItems2.Add("Bidang2");
		//		tempTable2.items = tempItems2;
		//		tempKeys2.Add(false);
		//		tempKeys2.Add(false);
		//		tempKeys2.Add(false);
		//		tempTable2.keys = tempKeys2;
		//		dTables.Add(tempTable2);
		//Tempat
		tempItems3.Add("Tempat");
		tempItems3.Add("Ruangan");
		tempTable3.items = tempItems3;
		tempKeys3.Add(true);
		tempTable3.keys = tempKeys3;
		dTables.Add(tempTable3);
		//Waktu
		tempItems4.Add("Waktu");
		tempItems4.Add("Kode Waktu");
		tempItems4.Add("Hari");
		tempItems4.Add("Jam");
		tempItems4.Add("Hasil");
		tempTable4.items = tempItems4;
		tempKeys4.Add(true);
		tempKeys4.Add(false);
		tempKeys4.Add(false);
		tempKeys4.Add(false);
		tempTable4.keys = tempKeys4;
		dTables.Add(tempTable4);
	}
	
	public static void InitJadwal3(){
		dTables = new List<SQLTable>();
		dTables.Clear();
		List<string> tempItems1 = new List<string>();
		List<string> tempItems2 = new List<string>();
		List<string> tempItems3 = new List<string>();
		List<string> tempItems4 = new List<string>();
		List<bool> tempKeys1 = new List<bool>();
		List<bool> tempKeys2 = new List<bool>();
		List<bool> tempKeys3 = new List<bool>();
		List<bool> tempKeys4 = new List<bool>();
		SQLTable tempTable1 = new SQLTable();
		SQLTable tempTable2 = new SQLTable();
		SQLTable tempTable3 = new SQLTable();
		SQLTable tempTable4 = new SQLTable();
		//Mahasiswa
		tempItems1.Add("Mahasiswa");
		tempItems1.Add("NIM");
		tempItems1.Add("Nama");
		tempItems1.Add("Judul");
		tempItems1.Add("Bidang");
		tempItems1.Add("Pembimbing1");
		tempItems1.Add("Pembimbing2");
		tempTable1.items = tempItems1;
		tempKeys1.Add(true);
		tempKeys1.Add(false);
		tempKeys1.Add(false);
		tempKeys1.Add(false);
		tempKeys1.Add(false);
		tempKeys1.Add(false);
		tempTable1.keys = tempKeys1;
		dTables.Add(tempTable1);
		//Dosen
		tempItems2.Add("Dosen");
		tempItems2.Add("Penguji1");
		tempItems2.Add("Bidang1");
		tempItems2.Add("Bidang2");
		tempItems2.Add("Penguji2");
		tempItems2.Add("Bidang1");
		tempItems2.Add("Bidang2");
		tempTable2.items = tempItems2;
		tempKeys2.Add(false);
		tempKeys2.Add(false);
		tempKeys2.Add(false);
		tempKeys2.Add(false);
		tempKeys2.Add(false);
		tempKeys2.Add(false);
		tempTable2.keys = tempKeys2;
		dTables.Add(tempTable2);
		//Tempat
		tempItems3.Add("Tempat");
		tempItems3.Add("Ruangan");
		tempTable3.items = tempItems3;
		tempKeys3.Add(true);
		tempTable3.keys = tempKeys3;
		dTables.Add(tempTable3);
		//Waktu
		tempItems4.Add("Waktu");
		tempItems4.Add("Kode Waktu");
		tempItems4.Add("Hari");
		tempItems4.Add("Jam");
		tempItems4.Add("Hasil");
		tempTable4.items = tempItems4;
		tempKeys4.Add(true);
		tempKeys4.Add(false);
		tempKeys4.Add(false);
		tempKeys4.Add(false);
		tempTable4.keys = tempKeys4;
		dTables.Add(tempTable4);
	}
}

public static class Load{
	public static void LoadMatakuliah(){
		SQLTables.InitMahasiswa();
		UsedTable.items.Add("Kode");
		UsedTable.items.Add("Tingkat");
		UsedTable.items.Add("Kelas");
		UsedTable.items.Add("Pengajar");
		UsedTable.items.Add("Bagian");
		UsedTable.items.Add("Lama");
		UsedTable.items.Add("Mahasiswa");
		UsedTable.items.Add("Ruangan");
		UsedTable.items.Add("Kapasitas");
		UsedTable.items.Add("Hari");
		UsedTable.items.Add("Jam1");
		UsedTable.items.Add("Jam2");
		UsedTable.items.Add("Keterangan");
		UsedTable.items.Add("Slot");
	}
	
	public static void LoadSeminarI(){
		SQLTables.InitSeminarI();
		UsedTable.items.Add("NIM");
		UsedTable.items.Add("Nama");
		UsedTable.items.Add("Judul");
		UsedTable.items.Add("Bidang");
		UsedTable.items.Add("Pembimbing1");
		UsedTable.items.Add("Pembimbing2");
		UsedTable.items.Add("Penguji");
		UsedTable.items.Add("Bidang1");
		UsedTable.items.Add("Bidang2");
		UsedTable.items.Add("Ruangan");
		UsedTable.items.Add("Hari");
		UsedTable.items.Add("Jam");
	}
	
	public static void LoadSeminarII(){
		SQLTables.InitSeminarII();
		UsedTable.items.Add("NIM");
		UsedTable.items.Add("Nama");
		UsedTable.items.Add("Judul");
		UsedTable.items.Add("Bidang");
		UsedTable.items.Add("Pembimbing1");
		UsedTable.items.Add("Pembimbing2");
		UsedTable.items.Add("Ruangan");
		UsedTable.items.Add("Hari");
		UsedTable.items.Add("Jam");
	}
	
	public static void LoadSidang(){
		SQLTables.InitSidang();
		UsedTable.items.Add("NIM");
		UsedTable.items.Add("Nama");
		UsedTable.items.Add("Judul");
		UsedTable.items.Add("Bidang");
		UsedTable.items.Add("Pembimbing1");
		UsedTable.items.Add("Pembimbing2");
		UsedTable.items.Add("Penguji1");
		UsedTable.items.Add("Bidang11");
		UsedTable.items.Add("Bidang12");
		UsedTable.items.Add("Penguji2");
		UsedTable.items.Add("Bidang21");
		UsedTable.items.Add("Bidang22");
		UsedTable.items.Add("Ruangan");
		UsedTable.items.Add("Hari");
		UsedTable.items.Add("Jam");
	}
	
	public static void LoadNewProject(){
		SQLTables.InitJadwal();
		UsedTable.items.Add("NIM");
		UsedTable.items.Add("Nama");
		UsedTable.items.Add("Judul");
		UsedTable.items.Add("Bidang");
		UsedTable.items.Add("Pembimbing1");
		UsedTable.items.Add("Pembimbing2");
		UsedTable.items.Add("Penguji");
		UsedTable.items.Add("Bidang1");
		UsedTable.items.Add("Bidang2");
		UsedTable.items.Add("Ruangan");
		UsedTable.items.Add("Kode Waktu");
		UsedTable.items.Add("Hari");
		UsedTable.items.Add("Jam");
		UsedTable.items.Add("Hasil");
	}
	
	public static void LoadNewProjectb(){
		SQLTables.InitJadwal();
		UsedTable.items.Add("NIM");
		UsedTable.items.Add("Nama");
		UsedTable.items.Add("Judul");
		UsedTable.items.Add("Bidang");
		UsedTable.items.Add("Pembimbing1");
		UsedTable.items.Add("Pembimbing2");
		UsedTable.items.Add("Penguji");
		UsedTable.items.Add("Bidang1");
		UsedTable.items.Add("Bidang2");
		UsedTable.items.Add("Ruangan");
		UsedTable.items.Add("Kode Waktu");
		UsedTable.items.Add("Hari");
		UsedTable.items.Add("Jam");
	}
	
	public static void LoadNewProject2(){
		SQLTables.InitJadwal2();
		UsedTable.items.Add("NIM");
		UsedTable.items.Add("Nama");
		UsedTable.items.Add("Judul");
		UsedTable.items.Add("Bidang");
		UsedTable.items.Add("Pembimbing1");
		UsedTable.items.Add("Pembimbing2");
		UsedTable.items.Add("Ruangan");
		UsedTable.items.Add("Kode Waktu");
		UsedTable.items.Add("Hari");
		UsedTable.items.Add("Jam");
		UsedTable.items.Add("Hasil");
	}
	
	public static void LoadNewProject3(){
		SQLTables.InitJadwal3();
		UsedTable.items.Add("NIM");
		UsedTable.items.Add("Nama");
		UsedTable.items.Add("Judul");
		UsedTable.items.Add("Bidang");
		UsedTable.items.Add("Pembimbing1");
		UsedTable.items.Add("Pembimbing2");
		UsedTable.items.Add("Penguji1");
		UsedTable.items.Add("Bidang1");
		UsedTable.items.Add("Bidang2");
		UsedTable.items.Add("Penguji2");
		UsedTable.items.Add("Bidang1");
		UsedTable.items.Add("Bidang2");
		UsedTable.items.Add("Ruangan");
		UsedTable.items.Add("Kode Waktu");
		UsedTable.items.Add("Hari");
		UsedTable.items.Add("Jam");
		UsedTable.items.Add("Hasil");
	}

	//	public static void LoadNewProject(){
	//		SQLTables.InitMahasiswa();
	//		UsedTable.items.Add("Kode");
	//		UsedTable.items.Add("Tingkat");
	//		UsedTable.items.Add("Kelas");
	//		UsedTable.items.Add("Pengajar");
	//		UsedTable.items.Add("Bagian");
	//		UsedTable.items.Add("Lama");
	//		UsedTable.items.Add("Mahasiswa");
	//		UsedTable.items.Add("Ruangan");
	//		UsedTable.items.Add("Kapasitas");
	//		UsedTable.items.Add("Hari");
	//		UsedTable.items.Add("Jam1");
	//		UsedTable.items.Add("Jam2");
	//		UsedTable.items.Add("Keterangan");
	//		UsedTable.items.Add("Slot");
	//	} 
}
