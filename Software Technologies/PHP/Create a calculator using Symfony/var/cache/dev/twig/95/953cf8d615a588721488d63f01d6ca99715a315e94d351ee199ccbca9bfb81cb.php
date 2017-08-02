<?php

/* @WebProfiler/Collector/exception.html.twig */
class __TwigTemplate_40de16e950efe8ebf68b9c23c4fdf2e24b7db5cd1ba8a2725187be4ca7ec1dac extends Twig_Template
{
    public function __construct(Twig_Environment $env)
    {
        parent::__construct($env);

        // line 1
        $this->parent = $this->loadTemplate("@WebProfiler/Profiler/layout.html.twig", "@WebProfiler/Collector/exception.html.twig", 1);
        $this->blocks = array(
            'head' => array($this, 'block_head'),
            'menu' => array($this, 'block_menu'),
            'panel' => array($this, 'block_panel'),
        );
    }

    protected function doGetParent(array $context)
    {
        return "@WebProfiler/Profiler/layout.html.twig";
    }

    protected function doDisplay(array $context, array $blocks = array())
    {
        $__internal_c1ffd53223c538bcd1e86e5388c73a61160a8fc5956196c6436286d814e4b3b6 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_c1ffd53223c538bcd1e86e5388c73a61160a8fc5956196c6436286d814e4b3b6->enter($__internal_c1ffd53223c538bcd1e86e5388c73a61160a8fc5956196c6436286d814e4b3b6_prof = new Twig_Profiler_Profile($this->getTemplateName(), "template", "@WebProfiler/Collector/exception.html.twig"));

        $this->parent->display($context, array_merge($this->blocks, $blocks));
        
        $__internal_c1ffd53223c538bcd1e86e5388c73a61160a8fc5956196c6436286d814e4b3b6->leave($__internal_c1ffd53223c538bcd1e86e5388c73a61160a8fc5956196c6436286d814e4b3b6_prof);

    }

    // line 3
    public function block_head($context, array $blocks = array())
    {
        $__internal_21d45a53accc5232e63b6acc7f87f5bbf505bc7689edefa38e4f0dfe7898de76 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_21d45a53accc5232e63b6acc7f87f5bbf505bc7689edefa38e4f0dfe7898de76->enter($__internal_21d45a53accc5232e63b6acc7f87f5bbf505bc7689edefa38e4f0dfe7898de76_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "head"));

        // line 4
        echo "    ";
        if ($this->getAttribute((isset($context["collector"]) ? $context["collector"] : $this->getContext($context, "collector")), "hasexception", array())) {
            // line 5
            echo "        <style>
            ";
            // line 6
            echo $this->env->getExtension('Symfony\Bridge\Twig\Extension\HttpKernelExtension')->renderFragment($this->env->getExtension('Symfony\Bridge\Twig\Extension\RoutingExtension')->getPath("_profiler_exception_css", array("token" => (isset($context["token"]) ? $context["token"] : $this->getContext($context, "token")))));
            echo "
        </style>
    ";
        }
        // line 9
        echo "    ";
        $this->displayParentBlock("head", $context, $blocks);
        echo "
";
        
        $__internal_21d45a53accc5232e63b6acc7f87f5bbf505bc7689edefa38e4f0dfe7898de76->leave($__internal_21d45a53accc5232e63b6acc7f87f5bbf505bc7689edefa38e4f0dfe7898de76_prof);

    }

    // line 12
    public function block_menu($context, array $blocks = array())
    {
        $__internal_af6d234693664324884a860ce65fa188a5b088fb3829680f5ef9e44e0c15cf73 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_af6d234693664324884a860ce65fa188a5b088fb3829680f5ef9e44e0c15cf73->enter($__internal_af6d234693664324884a860ce65fa188a5b088fb3829680f5ef9e44e0c15cf73_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "menu"));

        // line 13
        echo "    <span class=\"label ";
        echo (($this->getAttribute((isset($context["collector"]) ? $context["collector"] : $this->getContext($context, "collector")), "hasexception", array())) ? ("label-status-error") : ("disabled"));
        echo "\">
        <span class=\"icon\">";
        // line 14
        echo twig_include($this->env, $context, "@WebProfiler/Icon/exception.svg");
        echo "</span>
        <strong>Exception</strong>
        ";
        // line 16
        if ($this->getAttribute((isset($context["collector"]) ? $context["collector"] : $this->getContext($context, "collector")), "hasexception", array())) {
            // line 17
            echo "            <span class=\"count\">
                <span>1</span>
            </span>
        ";
        }
        // line 21
        echo "    </span>
";
        
        $__internal_af6d234693664324884a860ce65fa188a5b088fb3829680f5ef9e44e0c15cf73->leave($__internal_af6d234693664324884a860ce65fa188a5b088fb3829680f5ef9e44e0c15cf73_prof);

    }

    // line 24
    public function block_panel($context, array $blocks = array())
    {
        $__internal_a69202d96c42d4ef65f9039ad5fb60ac86d99ac046a0f809d1ea11eea41f0605 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_a69202d96c42d4ef65f9039ad5fb60ac86d99ac046a0f809d1ea11eea41f0605->enter($__internal_a69202d96c42d4ef65f9039ad5fb60ac86d99ac046a0f809d1ea11eea41f0605_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "panel"));

        // line 25
        echo "    <h2>Exceptions</h2>

    ";
        // line 27
        if ( !$this->getAttribute((isset($context["collector"]) ? $context["collector"] : $this->getContext($context, "collector")), "hasexception", array())) {
            // line 28
            echo "        <div class=\"empty\">
            <p>No exception was thrown and caught during the request.</p>
        </div>
    ";
        } else {
            // line 32
            echo "        <div class=\"sf-reset\">
            ";
            // line 33
            echo $this->env->getExtension('Symfony\Bridge\Twig\Extension\HttpKernelExtension')->renderFragment($this->env->getExtension('Symfony\Bridge\Twig\Extension\RoutingExtension')->getPath("_profiler_exception", array("token" => (isset($context["token"]) ? $context["token"] : $this->getContext($context, "token")))));
            echo "
        </div>
    ";
        }
        
        $__internal_a69202d96c42d4ef65f9039ad5fb60ac86d99ac046a0f809d1ea11eea41f0605->leave($__internal_a69202d96c42d4ef65f9039ad5fb60ac86d99ac046a0f809d1ea11eea41f0605_prof);

    }

    public function getTemplateName()
    {
        return "@WebProfiler/Collector/exception.html.twig";
    }

    public function isTraitable()
    {
        return false;
    }

    public function getDebugInfo()
    {
        return array (  117 => 33,  114 => 32,  108 => 28,  106 => 27,  102 => 25,  96 => 24,  88 => 21,  82 => 17,  80 => 16,  75 => 14,  70 => 13,  64 => 12,  54 => 9,  48 => 6,  45 => 5,  42 => 4,  36 => 3,  11 => 1,);
    }

    public function getSource()
    {
        return "{% extends '@WebProfiler/Profiler/layout.html.twig' %}

{% block head %}
    {% if collector.hasexception %}
        <style>
            {{ render(path('_profiler_exception_css', { token: token })) }}
        </style>
    {% endif %}
    {{ parent() }}
{% endblock %}

{% block menu %}
    <span class=\"label {{ collector.hasexception ? 'label-status-error' : 'disabled' }}\">
        <span class=\"icon\">{{ include('@WebProfiler/Icon/exception.svg') }}</span>
        <strong>Exception</strong>
        {% if collector.hasexception %}
            <span class=\"count\">
                <span>1</span>
            </span>
        {% endif %}
    </span>
{% endblock %}

{% block panel %}
    <h2>Exceptions</h2>

    {% if not collector.hasexception %}
        <div class=\"empty\">
            <p>No exception was thrown and caught during the request.</p>
        </div>
    {% else %}
        <div class=\"sf-reset\">
            {{ render(path('_profiler_exception', { token: token })) }}
        </div>
    {% endif %}
{% endblock %}
";
    }
}
