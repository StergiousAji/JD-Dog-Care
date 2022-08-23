# Utility to generate Google Chart API gantt charts from a csv file.
import sys, csv

HEAD = """
<html>
<head>
  <script type="text/javascript" src="https://www.gstatic.com/charts/loader.js"></script>
  <script type="text/javascript">
    google.charts.load('current', {'packages':['gantt']});
    google.charts.setOnLoadCallback(drawChart);

    function toMilliseconds(minutes) {
      return minutes * 60 * 1000;
    }

    function daysToMilliseconds(days) {
      return days * 24 * 60 * 60 * 1000;
    }

    function drawChart() {

      var chartData = new google.visualization.DataTable();
      chartData.addColumn('string', 'Task ID');
      chartData.addColumn('string', 'Task Name');
      chartData.addColumn('string', 'Resource');
      chartData.addColumn('date', 'Start');
      chartData.addColumn('date', 'End');
      chartData.addColumn('number', 'Duration');
      chartData.addColumn('number', 'Percent Complete');
      chartData.addColumn('string', 'Dependencies');
"""
DATAROWS = """
// TEST DATA FROM CSV FILE HERE
           chartData.addRows([
        ['Analysis', 'Define Problem', new Date(2019, 0, 1), null, daysToMilliseconds(3),  100,  null],
        ['Design', 'Data Dictionary',  null, null, daysToMilliseconds(3), 25, 'Analysis'],
        ['DBDesign', 'Create normalised tables', null, null, daysToMilliseconds(1), 20, 'Design'],
        ['Develop', 'Build Solution', null, null, daysToMilliseconds(1), 0, 'Analysis,DBDesign'],
        ['Test', 'Complete Testing',  null, null, daysToMilliseconds(1), 100, 'Develop']
      ]);"""
FOOTER = """

      var options = {
        height:800 
      };

      var chart = new google.visualization.Gantt(document.getElementById('chart_div'));

      chart.draw(chartData, options);
    }
  </script>
</head>
<body>
<img src="lcc_logo.png"/>
<h1>Candidate Number: 4211</h1>
<h2>JD Dog Care</h2>
<h3>Project Planning</h3>
<table style="border: 1px solid black;">
<tr><th>Date</th><th>Version</th></tr>
<tr><td>06/11/2019</th><th>1.0</th></tr>
</table>
<br/>
  <div id="chart_div"></div>
<hr/>
<a href="https://developers.google.com/chart/interactive/docs/gallery/ganttchart">Customise this chart using HTML/JS</a>
</body>
</html>"""

def writeToFile(gantt):
  with open('gantt_chart.html', 'w') as out_file:
    out_file.write(gantt)
  print("gantt_chart.html written to file.")

def checkDate(entry):
  #print("Checking", entry)
  if entry not in ['null','']:
    start_date = entry.split('/')
    #print(start_date)
    return "new Date({0},{1},{2})".format(start_date[2],int(start_date[1])-1,start_date[0])
  else:
    return entry  
	
def nullCheck(entry):
  #print("Checking", entry)
  if entry == '':
    return 'null'
  else:
    return '\'{0}\''.format(entry) 
	
def getDataRows():
  add_rows = "chartData.addRows(["
  with open('gantt.csv','r') as in_file:
    readCSV = csv.DictReader(in_file, delimiter=',')
    for row in readCSV:
      add_rows += "['{0}','{1}','{2}',{3},{4},daysToMilliseconds({5}),{6},{7}],\n".format(row['Task ID'],
																			row['Task Name'],
																			row['Resource'],
																			checkDate(row['Start']),
																			checkDate(row['End']),
																			row['Duration'], 
																			row['Percent Complete'], 
																			nullCheck(row['Dependencies']))
  add_rows = add_rows.rstrip(',')
  add_rows += "]);"
  return add_rows
		
def main():
  print("*** LCC Gantt Chart Generator ***")
  print("Enter your project dates in gantt.csv and then run this utility.")
  gantt = HEAD + getDataRows() + FOOTER
  writeToFile(gantt)
  print("Done.")
  print("Edit the html source to add your candidate number or any other customisations.")
  print("Change the date and version, then save as PDF.")
  raw_input()

if __name__ == "__main__":
  main()