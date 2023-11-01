<script>
	import { onMount } from 'svelte';
  import * as d3 from "d3";
	import * as Plot from "@observablehq/plot";

  onMount(async () => {
    const plot = Plot.rectY({length: 10000}, Plot.binX({y: "count"}, {x: d3.randomNormal()})).plot();
    const div = document.querySelector("#myplot");
    if(div) div.append(plot);

    const data = await d3.csv('/data/AP.csv');
    console.log(data);

    const plot2 = Plot.plot({
      marks: [
        Plot.barY(data, {x: "Team", y: "42"})
      ]
    });

    const div2 = document.querySelector("#myplot2");
    if(div2) div2.append(plot2);
  });
</script>

<div id="myplot"></div>
<div id="myplot2"></div>